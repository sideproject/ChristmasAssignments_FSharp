//// Learn more about F# at http://fsharp.net
//(*
//eliz:1:child:x,y
//margaret:1:parent:mary,anne
//elise:1:parent:james,hollie
//christopher:1:child:shawn,daniel
//julia:1:child:carla,mallory
//charlie:2:parent:jim,dean
//anne:2:parent:sarah,carla
//emily:2:child:sam,james
//laura:2:child:martha,andrew
//jim:3:parent:daniel,charlie
//hollie:3:parent:elise,sarah
//andrew:3:child:joeseph,sam
//amie:3:child:emiliy,martha
//frank:4:parent:margaret,shawn
//carla:4:parent:anne,mary
//mallory:4:child:christopher,joseph
//martha:4:child:amie,julia
//mary:5:parent:hollie,elise
//dean:5:parent:frank,jim
//james:5:child:mallory,christopher
//joeseph:5:child:andrew,laura
//sarah:6:parent:charlie,margaret
//shawn:6:parent:dean,frank
//sam:6:child:laura,amie
//daniel:6:child:julia,emily
//*)
//
module RubyQuiz2
//
//let eliz =          ("eliz", "1", "child", [])
//let margaret =      ("margaret", "1", "parent", ["mary"; "anne";])
//let elise =         ("elise", "1", "parent", ["james"; "hollie";])
//let christopher =   ("christopher", "1", "child", ["shawn"; "daniel";])
//let julia =         ("julia", "1", "child", ["carla"; "mallory";])
//let charlie =       ("charlie", "2", "parent", ["jim"; "dean";])
//let anne =          ("anne", "2", "parent", ["sarah"; "carla";])
//let emily =         ("emily", "2", "child", ["sam"; "james";])
//let laura =         ("laura", "2", "child", ["martha"; "andrew";])
//let jim =           ("jim", "3", "parent", ["daniel"; "charlie";])
//let hollie =        ("hollie", "3", "parent", ["elise"; "sarah";])
//let andrew =        ("andrew", "3", "child", ["joeseph"; "sam";])
//let amie =          ("amie", "3", "child", ["emiliy"; "martha";])
//let frank =         ("frank", "4", "parent", ["margaret"; "shawn";])
//let carla =         ("carla", "4", "parent", ["anne"; "mary";])
//let mallory =       ("mallory", "4", "child", ["christopher"; "joseph";])
//let martha =        ("martha", "4", "child", ["amie"; "julia";])
//let mary =          ("mary", "5", "parent", ["hollie"; "elise";])
//let dean =          ("dean", "5", "parent", ["frank"; "jim";])
//let james =         ("james", "5", "child", ["mallory"; "christopher";])
//let joeseph =       ("joeseph", "5", "child", ["andrew"; "laura";])
//let sarah =         ("sarah", "6", "parent", ["charlie"; "margaret";])
//let shawn =         ("shawn", "6", "parent", ["dean"; "frank";])
//let sam =           ("sam", "6", "child", ["laura"; "amie";])
//let daniel =        ("daniel", "6", "child", ["julia"; "emily"; ])
//
//let list = [eliz; margaret; elise; christopher; julia; 
//            charlie; anne; emily; laura; 
//            jim; hollie; andrew; amie; 
//            frank; carla; mallory; martha; 
//            mary; dean; james; joeseph; 
//            sarah; shawn; sam; daniel]
//
//let getfamilycount l =
//    let rec getfamilycount_kernel l acc =
//        if List.isEmpty l then List.length acc
//        else
//            let(_,familyid,_,_) = List.head l
//            let found = List.tryFind (fun x -> x = familyid) acc
//            if found = None then
//                getfamilycount_kernel (List.tail l) (familyid::acc)
//            else
//                getfamilycount_kernel (List.tail l) acc
//    getfamilycount_kernel l []
//
//let familycount = getfamilycount list
//
//let randomize list = 
//    let comp i j = 
//        if i > j then 1
//        else if i < j then -1
//        else 0
//
//    let random = new System.Random() 
//    let list'=
//        list
//        |> List.map (fun i -> (random.Next(), i))
//        |> List.sortWith (fun (i1,_) (i2,_) -> comp i1 i2)
//    let (_,list'') = List.unzip list' 
//    list''
//
//let rec comb l1 l2 builder = 
//    if List.isEmpty l1 then List.rev builder
//    else
//        let h1 = List.head l1
//        let h2 = List.head l2
//        let combination = (h1, h2)
//        comb (List.tail l1) (List.tail l2) (combination::builder)
//
//let rec printcombinations cs = 
//    if List.isEmpty cs then System.Console.WriteLine("")
//    else
//        let (a, b) = List.head cs
//        System.Console.WriteLine(System.String.Format("{0}:{1}", a, b))
//        printcombinations (List.tail cs)
//
//let rule_notself l = 
//    let rec rule_notself_kernel l acc =
//        if List.isEmpty l then acc
//        else if acc = false then false
//        else
//            let (xfrom, xto) = List.head l
//            if xfrom <> xto then
//                rule_notself_kernel (List.tail l) true
//            else
//                false
//    rule_notself_kernel l true
//    
//let rule_notsamefamily l = 
//    let rec rule_notsamefamily_kernel l acc =
//        if List.isEmpty l then acc
//        else
//            let (xfrom, xto) = List.head l            
//            let (_, last1, _, _) = xfrom
//            let (_, last2, _, _) = xto
//            
//            if last1 <> last2 then
//                rule_notsamefamily_kernel (List.tail l) true
//            else
//                false
//    rule_notsamefamily_kernel l true
//    
//let rule_nopreviouspeople l = 
//    let rec rule_nopreviouspeople_kernel l acc =
//        if List.isEmpty l then acc
//        else
//            let (xfrom, xto) = List.head l
//            
//            let (tofirst,_,_,_) = xto
//            let (_,_,_,prev) = xfrom
//            
//            let found = List.tryFind (fun x -> x = tofirst) prev
//            if found = None then
//                rule_nopreviouspeople_kernel (List.tail l) true
//            else
//                false
//    rule_nopreviouspeople_kernel l true          
//        
//
////unfinished
//let rule_maxonedifficult l = 
//    let rec getfamilyofassignment l a = 
//        if List.isEmpty l then ""
//        else
//            let (xfrom,xto) = List.head l
//            let (_,fromlname,_,_) = xfrom
//            let (tofname,_,_,_) = xto
//            if tofname = a then fromlname
//            else getfamilyofassignment (List.tail l) a
//            
//    let family1 = getfamilyofassignment l "andrew"
//    let family2 = getfamilyofassignment l "jimmy"
//    family1 <> family2
//
//let getfamilyassignments l f = 
//    let rec getfamilyassignments_kernel l f acc =
//        if List.isEmpty l then acc
//        else
//            let (xfrom,xto) = List.head l
//            let (_,fromlname,_,_) = xfrom
//            if fromlname = f then 
//                getfamilyassignments_kernel (List.tail l) f (xto::acc)
//            else 
//                getfamilyassignments_kernel (List.tail l) f acc
//    getfamilyassignments_kernel l f []
//  
//let rule_correctparrentchildratio l = 
//    let getagecount l age =
//        let rec getagecount_kernel l age acc =
//            if List.isEmpty l then acc
//            else
//                let (_,_,agetype,_) = List.head l
//                if agetype = age then 
//                    getagecount_kernel (List.tail l) age (acc + 1)
//                else 
//                    getagecount_kernel (List.tail l) age acc
//        getagecount_kernel l age 0
//
//    let getagecounts l f =
//        let assignments = getfamilyassignments l f
//        let child = getagecount assignments "child"
//        let parent = getagecount assignments "parent"
//        (child,parent)
//
//    //max 2 parents and 3 children
//    for i in [1..familycount] do
//        
//    true
//    
//let rule_goodfamilymix l =
//    //make sure that we don't assign one family all of another family (max 50% same family)
//    true
//         
//let listok l = 
//    (rule_notself l) 
//    && (rule_notsamefamily l) 
//    && (rule_nopreviouspeople l) 
//    && (rule_maxonedifficult l) 
//    && (rule_correctparrentchildratio l) 
//    && (rule_goodfamilymix l)
//    
//let rec go_n l n = 
//    if n = 0 then System.Console.WriteLine("MAX RECURSION REACHED")
//    else
//        let l' = randomize l
//        let combinations = comb l l' []
//        
//        if listok combinations then
//            printcombinations combinations
//        else
//            go_n l (n - 1)
//    
//go_n list 1000000
//
//
//
// //let rec anag (p:string) (w:string) = 
////    if w.ToString().Length = 1 then
////        System.Console.WriteLine((p + w))
////    else
////        for i in [0 .. ((w.Length)-1)] do
////            let cur = w.Chars(i).ToString()
////            let before = w.Substring(0,i)
////            let after = w.Substring(i + 1)
////            anag (p + cur) (before+after)            
////
////anag "" "ABCDEFGHIJKLMNOP"
