// Learn more about F# at http://fsharp.net
open AssignmentGenerator

let eliz =          { FirstName="eliz";         LastName="1"; AgeType="child";  Previous=[                              "martha";]}
let margaret =      { FirstName="margaret";     LastName="1"; AgeType="parent"; Previous=["mary";        "anne";        "laura";]}
let elise =         { FirstName="elise";        LastName="1"; AgeType="parent"; Previous=["james";       "hollie";      "sam";]}
let christopher =   { FirstName="christopher";  LastName="1"; AgeType="child";  Previous=["shawn";       "daniel";      "anne";]}
let julia =         { FirstName="julia";        LastName="1"; AgeType="child";  Previous=["carla";       "mallory";     "charlie";]}
let charlie =       { FirstName="charlie";      LastName="2"; AgeType="parent"; Previous=["jimmy";       "dean";        "hollie";]}
let anne =          { FirstName="anne";         LastName="2"; AgeType="parent"; Previous=["sarah";       "carla";       "christopher";]}
let emily =         { FirstName="emily";        LastName="2"; AgeType="child";  Previous=["sam";         "james";       "andrew";]}
let laura =         { FirstName="laura";        LastName="2"; AgeType="child";  Previous=["martha";      "andrew";      "jimmy";]}
let jimmy =         { FirstName="jimmy";        LastName="3"; AgeType="parent"; Previous=["daniel";      "charlie";     "elise";]}
let hollie =        { FirstName="hollie";       LastName="3"; AgeType="parent"; Previous=["elise";       "sarah";       "mallory";]}
let andrew =        { FirstName="andrew";       LastName="3"; AgeType="child";  Previous=["joeseph";     "sam";         "frank";]}
let amie =          { FirstName="amie";         LastName="3"; AgeType="child";  Previous=["emiliy";      "martha";      "emily";]}
let frank =         { FirstName="frank";        LastName="4"; AgeType="parent"; Previous=["margaret";    "shawn";       "daniel";]}
let carla =         { FirstName="carla";        LastName="4"; AgeType="parent"; Previous=["anne";        "mary";        "dean";]}
let mallory =       { FirstName="mallory";      LastName="4"; AgeType="child";  Previous=["christopher"; "joseph";      "amie";]}
let martha =        { FirstName="martha";       LastName="4"; AgeType="child";  Previous=["amie";        "julia";       "mary";]}
let mary =          { FirstName="mary";         LastName="5"; AgeType="parent"; Previous=["hollie";      "elise";       "eliz";]}
let dean =          { FirstName="dean";         LastName="5"; AgeType="parent"; Previous=["frank";       "jimmy";       "shawn";]}
let james =         { FirstName="james";        LastName="5"; AgeType="child";  Previous=["mallory";     "christopher"; "sarah";]}
let joeseph =       { FirstName="joeseph";      LastName="5"; AgeType="child";  Previous=["andrew";      "laura";       "julia";]}
let sarah =         { FirstName="sarah";        LastName="6"; AgeType="parent"; Previous=["charlie";     "margaret";    "james";]}
let shawn =         { FirstName="shawn";        LastName="6"; AgeType="parent"; Previous=["dean";        "frank";       "carla";]}
let sam =           { FirstName="sam";          LastName="6"; AgeType="child";  Previous=["laura";       "amie";        "joseph";]}
let daniel =        { FirstName="daniel";       LastName="6"; AgeType="child";  Previous=["julia";       "emily";       "margaret";]}

let people = [  eliz; margaret; elise; christopher; julia; 
                charlie; anne; emily; laura; 
                jimmy; hollie; andrew; amie; 
                frank; carla; mallory; martha; 
                mary; dean; james; joeseph; 
                sarah; shawn; sam; daniel
             ]

System.Console.WriteLine("Running...");

let start = System.DateTime.Now
AssignmentGenerator.find_assignments people 2000000
let finish = System.DateTime.Now   
System.Console.WriteLine(finish - start)



