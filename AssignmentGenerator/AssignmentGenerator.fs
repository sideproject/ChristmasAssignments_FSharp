module AssignmentGenerator

type Person = 
    {
        FirstName : string;
        LastName : string;
        AgeType : string;
        Previous : string list; 
    }
    override this.ToString() = sprintf "%s %s %s %A" this.FirstName this.LastName this.AgeType this.Previous

type Assignment =
    {
        From : Person;
        To : Person
    }

let eliz =          { FirstName="eliz"; LastName="1"; AgeType="child"; Previous=["martha";]}
let margaret =      { FirstName="margaret"; LastName="1"; AgeType="parent"; Previous=["mary"; "anne"; "laura";]}
let elise =         { FirstName="elise"; LastName="1"; AgeType="parent"; Previous=["james"; "hollie"; "sam";]}
let christopher =   { FirstName="christopher"; LastName="1"; AgeType="child"; Previous=["shawn"; "daniel"; "anne";]}
let julia =         { FirstName="julia"; LastName="1"; AgeType="child"; Previous=["carla"; "mallory"; "charlie"]}
let charlie =       { FirstName="charlie"; LastName="2"; AgeType="parent"; Previous=["jimmy"; "dean"; "hollie";]}
let anne =          { FirstName="anne"; LastName="2"; AgeType="parent"; Previous=["sarah"; "carla"; "christopher";]}
let emily =         { FirstName="emily"; LastName="2"; AgeType="child"; Previous=["sam"; "james"; "andrew";]}
let laura =         { FirstName="laura"; LastName="2"; AgeType="child"; Previous=["martha"; "andrew"; "jimmy"; ]}
let jimmy =         { FirstName="jimmy"; LastName="3"; AgeType="parent"; Previous=["daniel"; "charlie"; "elise";]}
let hollie =        { FirstName="hollie"; LastName="3"; AgeType="parent"; Previous=["elise"; "sarah"; "mallory";]}
let andrew =        { FirstName="andrew"; LastName="3"; AgeType="child"; Previous=["joeseph"; "sam"; "frank";]}
let amie =          { FirstName="amie"; LastName="3"; AgeType="child"; Previous=["emiliy"; "martha"; "emily";]}
let frank =         { FirstName="frank"; LastName="4"; AgeType="parent"; Previous=["margaret"; "shawn"; "daniel";]}
let carla =         { FirstName="carla"; LastName="4"; AgeType="parent"; Previous=["anne"; "mary"; "dean";]}
let mallory =       { FirstName="mallory"; LastName="4"; AgeType="child"; Previous=["christopher"; "joseph"; "amie";]}
let martha =        { FirstName="martha"; LastName="4"; AgeType="child"; Previous=["amie"; "julia"; "mary";]}
let mary =          { FirstName="mary"; LastName="5"; AgeType="parent"; Previous=["hollie"; "elise"; "eliz";]}
let dean =          { FirstName="dean"; LastName="5"; AgeType="parent"; Previous=["frank"; "jimmy"; "shawn";]}
let james =         { FirstName="james"; LastName="5"; AgeType="child"; Previous=["mallory"; "christopher"; "sarah";]}
let joeseph =       { FirstName="joeseph"; LastName="5"; AgeType="child"; Previous=["andrew"; "laura"; "julia";]}
let sarah =         { FirstName="sarah"; LastName="6"; AgeType="parent"; Previous=["charlie"; "margaret"; "james";]}
let shawn =         { FirstName="shawn"; LastName="6"; AgeType="parent"; Previous=["dean"; "frank"; "carla";]}
let sam =           { FirstName="sam"; LastName="6"; AgeType="child"; Previous=["laura"; "amie"; "joseph";]}
let daniel =        { FirstName="daniel"; LastName="6"; AgeType="child"; Previous=["julia"; "emily"; "margaret"; ]}

let people = [eliz; margaret; elise; christopher; julia; 
            charlie; anne; emily; laura; 
            jimmy; hollie; andrew; amie; 
            frank; carla; mallory; martha; 
            mary; dean; james; joeseph; 
            sarah; shawn; sam; daniel]


/////////////////////////////////////////////rules///////////////////////////////////////////////////////////////////
let rule_not_self assignments = 
    let q = List.tryFind (fun x -> x.From.FirstName = x.To.FirstName) assignments
    q = None

let rule_not_same_family assignments =
    let q = List.tryFind (fun x -> x.From.LastName = x.To.LastName) assignments
    q = None

let rule_no_previous_people assignments = 
    let q = List.tryFind (fun assignment ->
                                let q2 = List.tryFind(fun previousPerson -> assignment.To.FirstName = previousPerson) assignment.From.Previous
                                // we found someone assigned to someone they already had
                                q2 <> None 
                         ) assignments
    //make sure we found no one
    q = None 

let rule_max_one_difficult assignments = 
    let andrew_assignment = List.find (fun a -> a.To.FirstName = "andrew") assignments
    let jimmy_assignment = List.find (fun a -> a.To.FirstName = "jimmy") assignments
    andrew_assignment.From.LastName <> jimmy_assignment.From.LastName

let parent_to_child_ratio assignments families =
    let rec finder assignments families2 acc = 
        if List.isEmpty families2 then acc
        else
            let family = List.head families2
            let child_count = List.sumBy (fun x -> if x.From.LastName = family && x.To.AgeType = "child"  then 1 else 0) assignments
            let parent_count = List.sumBy (fun x -> if x.From.LastName = family && x.To.AgeType = "parent"  then 1 else 0) assignments
            if (child_count > 1 && parent_count > 0) then
                finder assignments (List.tail families2) true
            else
                false
    finder assignments families true

let rule_good_family_mix assignments families =    
//make sure that we don't assign one family all of another family (max 60% same family)
//bean family currently has 5 people (2 / 5 = 0.4) [instead of 50% -- 0.5 seems to be impossible to randomly find
//1 - 0.4 = 0.6 -> 60%

    let rec finder assignments families2 acc = 
        if List.isEmpty families2 then acc
        else
            let family = List.head families2
            let family_assignments = List.filter ( fun x -> x.From.LastName = family) assignments
            let families_assigned_to = List.map (fun x -> x.To.LastName) family_assignments
            let distinct_families_assigned_to = Set.toList (set families_assigned_to)
            
            let family_member_count = List.length family_assignments
            let ratio = (float)(List.length distinct_families_assigned_to) / (float)family_member_count 
            
            if ratio >= 0.4 then
                finder assignments (List.tail families2) true
            else
                false
    finder assignments families true


let rule_no_previous_family_assignments assignments = 
//don't assign a family the same people as last year
    let rec get_last_list_node list =
        if List.length list = 1 then List.head list
        else
            get_last_list_node (List.tail list) 

    let rec get_previous_family_assignments assignments builder = 
        if List.isEmpty assignments then builder
        else
            let cur = List.head assignments
            let previous_person = (get_last_list_node cur.From.Previous)
            let previous_assignment = (cur.From.LastName, previous_person)
            get_previous_family_assignments (List.tail assignments) (previous_assignment::builder)
    
    let rec check_previous assignments previous_assignments = 
        if List.isEmpty previous_assignments then true
        else
            let prev = List.head previous_assignments
            let (fromFamily, previousFirstName) = prev
            let q = (List.tryFind (fun x -> x.From.LastName = fromFamily && x.To.FirstName = previousFirstName) assignments)
            if q = None then
                check_previous assignments (List.tail previous_assignments)
            else
                false
    let previous_assignments = get_previous_family_assignments assignments []
    check_previous assignments previous_assignments

/////////////////////////////////////////////rules///////////////////////////////////////////////////////////////////

let randomize list seed = 
    let comp i j = 
        if i > j then 1
        else if i < j then -1
        else 0

    let seed' = (int)System.DateTime.Now.Ticks + seed
    let random = new System.Random(seed') 
    let list'=
        list
        |> List.map (fun i -> (random.Next(), i))
        |> List.sortWith (fun (i1,_) (i2,_) -> comp i1 i2)
    let (_,list'') = List.unzip list' 
    list''

let rec print_assignments assignments = 
    if List.isEmpty assignments then System.Console.WriteLine("")
    else
        let h = List.head assignments
        //System.Console.WriteLine(System.String.Format("{0}:{1}", h.From, h.To))
        System.Console.WriteLine(System.String.Format("{0}:{1}", h.From.FirstName, h.To.FirstName))
        print_assignments (List.tail assignments)

let rec create_assignment_list person_list1 person_list2 builder = 
    if List.isEmpty person_list1 then List.rev builder
    else
        let person1 = List.head person_list1
        let person2 = List.head person_list2
        let assignment = {From=person1; To=person2}
        create_assignment_list (List.tail person_list1) (List.tail person_list2) (assignment::builder)

let assignments_are_valid assignments = 
    let families = List.map (fun x -> x.From.LastName) assignments
    let distinct_families = Set.toList (set families)

    (rule_not_self assignments) 
        && (rule_not_same_family assignments) 
        && (rule_no_previous_people assignments) 
        && (rule_max_one_difficult assignments) 
        && (parent_to_child_ratio assignments distinct_families) 
        && (rule_good_family_mix assignments distinct_families)
        && (rule_no_previous_family_assignments assignments)
        

let rec find_assignments people_list n = 
    if n = 0 then System.Console.WriteLine("MAX RECURSION REACHED")
    else
        if n % 100000 = 0 then System.Console.Write(".")
        let people_list' = randomize people_list (n * 2)
        let assignments = create_assignment_list people_list people_list' []
        
        if assignments_are_valid assignments then
            System.Console.WriteLine(n.ToString())
            print_assignments assignments
        else
            find_assignments people_list (n - 1)


//let start = System.DateTime.Now
//find_assignments people 5000000
//let finish = System.DateTime.Now   
//System.Console.WriteLine(finish - start)
