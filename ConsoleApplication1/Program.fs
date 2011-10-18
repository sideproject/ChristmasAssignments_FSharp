// Learn more about F# at http://fsharp.net
open AssignmentGenerator

let eliz =          { FirstName="eliz";         LastName="1"; AgeType="child";  Previous=[                              "martha";      "sam" ]}
let margaret =      { FirstName="margaret";     LastName="1"; AgeType="parent"; Previous=["mary";        "anne";        "laura";       "daniel" ]}
let elise =         { FirstName="elise";        LastName="1"; AgeType="parent"; Previous=["james";       "hollie";      "sam";         "anne" ]}
let christopher =   { FirstName="christopher";  LastName="1"; AgeType="child";  Previous=["shawn";       "daniel";      "anne";        "carla" ]}
let julia =         { FirstName="julia";        LastName="1"; AgeType="child";  Previous=["carla";       "mallory";     "charlie";     "dean" ]}
let charlie =       { FirstName="charlie";      LastName="2"; AgeType="parent"; Previous=["jimmy";       "dean";        "hollie";      "margaret" ]}
let anne =          { FirstName="anne";         LastName="2"; AgeType="parent"; Previous=["sarah";       "carla";       "christopher"; "frank" ]}
let emily =         { FirstName="emily";        LastName="2"; AgeType="child";  Previous=["sam";         "james";       "andrew";      "christopher" ]}
let laura =         { FirstName="laura";        LastName="2"; AgeType="child";  Previous=["martha";      "andrew";      "jimmy";       "joeseph" ]}
let jimmy =         { FirstName="jimmy";        LastName="3"; AgeType="parent"; Previous=["daniel";      "charlie";     "elise";       "mary" ]}
let hollie =        { FirstName="hollie";       LastName="3"; AgeType="parent"; Previous=["elise";       "sarah";       "mallory";     "shawn" ]}
let andrew =        { FirstName="andrew";       LastName="3"; AgeType="child";  Previous=["joeseph";     "sam";         "frank";       "laura" ]}
let amie =          { FirstName="amie";         LastName="3"; AgeType="child";  Previous=["emiliy";      "martha";      "emily";       "mallory" ]}
let frank =         { FirstName="frank";        LastName="4"; AgeType="parent"; Previous=["margaret";    "shawn";       "daniel";      "emily" ]}
let carla =         { FirstName="carla";        LastName="4"; AgeType="parent"; Previous=["anne";        "mary";        "dean";        "hollie" ]}
let mallory =       { FirstName="mallory";      LastName="4"; AgeType="child";  Previous=["christopher"; "joseph";      "amie";        "james" ]}
let martha =        { FirstName="martha";       LastName="4"; AgeType="child";  Previous=["amie";        "julia";       "mary";        "eliz" ]}
let mary =          { FirstName="mary";         LastName="5"; AgeType="parent"; Previous=["hollie";      "elise";       "eliz";        "andrew" ]}
let dean =          { FirstName="dean";         LastName="5"; AgeType="parent"; Previous=["frank";       "jimmy";       "shawn";       "martha" ]}
let james =         { FirstName="james";        LastName="5"; AgeType="child";  Previous=["mallory";     "christopher"; "sarah";       "elise" ]}
let joeseph =       { FirstName="joeseph";      LastName="5"; AgeType="child";  Previous=["andrew";      "laura";       "julia";       "sarah" ]}
let sarah =         { FirstName="sarah";        LastName="6"; AgeType="parent"; Previous=["charlie";     "margaret";    "james";       "julia" ]}
let shawn =         { FirstName="shawn";        LastName="6"; AgeType="parent"; Previous=["dean";        "frank";       "carla";       "jimmy" ]}
let sam =           { FirstName="sam";          LastName="6"; AgeType="child";  Previous=["laura";       "amie";        "joseph";      "charlie" ]}
let daniel =        { FirstName="daniel";       LastName="6"; AgeType="child";  Previous=["julia";       "emily";       "margaret";    "amie" ]}
  

let people = [  eliz; margaret; elise; christopher; julia; 
                charlie; anne; emily; laura; 
                jimmy; hollie; andrew; amie; 
                frank; carla; mallory; martha; 
                mary; dean; james; joeseph; 
                sarah; shawn; sam; daniel
             ]

System.Console.WriteLine("Running...");

let start = System.DateTime.Now
AssignmentGenerator.find_assignments people 10000000
let finish = System.DateTime.Now   
System.Console.WriteLine(finish - start)



