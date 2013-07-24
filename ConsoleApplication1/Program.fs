// Learn more about F# at http://fsharp.net
open AssignmentGenerator

let margaret =      { FirstName="margaret";     LastName="1"; AgeType="parent"; Previous=["mary";        "anne";        "laura";       "daniel";      "jimmy";     ]}
let elise =         { FirstName="elise";        LastName="1"; AgeType="parent"; Previous=["james";       "hollie";      "sam";         "anne";        "megan";      ]}
let christopher =   { FirstName="christopher";  LastName="1"; AgeType="child";  Previous=["shawn";       "daniel";      "anne";        "carla";       "laura";      ]}
let eliz =          { FirstName="eliz";         LastName="1"; AgeType="child";  Previous=[                              "martha";      "sam";         "shawn";      ]}
let julia =         { FirstName="julia";        LastName="1"; AgeType="child";  Previous=["carla";       "mallory";     "charlie";     "dean";        "hollie";     ]}
//let jacob =         { FirstName="jacob";        LastName="1"; AgeType="child";  Previous=[                                                          "X"           ]}
let charlie =       { FirstName="charlie";      LastName="2"; AgeType="parent"; Previous=["jimmy";       "dean";        "hollie";      "margaret";    "elise";      ]}
let anne =          { FirstName="anne";         LastName="2"; AgeType="parent"; Previous=["sarah";       "carla";       "christopher"; "frank";       "james";      ]}
let emily =         { FirstName="emily";        LastName="2"; AgeType="child";  Previous=["sam";         "james";       "andrew";      "christopher"; "dean";       ]}
let laura =         { FirstName="laura";        LastName="2"; AgeType="child";  Previous=["martha";      "andrew";      "jimmy";       "joeseph";     "daniel";     ]}
let tyler =         { FirstName="tyler";        LastName="2"; AgeType="child";  Previous=[                                                            "X"           ]}
let jimmy =         { FirstName="jimmy";        LastName="3"; AgeType="parent"; Previous=["daniel";      "charlie";     "elise";       "mary";        "anne";       ]}
let hollie =        { FirstName="hollie";       LastName="3"; AgeType="parent"; Previous=["elise";       "sarah";       "mallory";     "shawn";       "carla";      ]}
let andrew =        { FirstName="andrew";       LastName="3"; AgeType="child";  Previous=["joeseph";     "sam";         "frank";       "laura";       "sarah";      ]}
let megan =         { FirstName="megan";        LastName="3"; AgeType="child";  Previous=[                                                            "mallory";    ]}
let amie =          { FirstName="amie";         LastName="3"; AgeType="child";  Previous=["emiliy";      "martha";      "emily";       "mallory";     "sam";        ]}
let frank =         { FirstName="frank";        LastName="4"; AgeType="parent"; Previous=["margaret";    "shawn";       "daniel";      "emily";       "charlie";    ]}
let carla =         { FirstName="carla";        LastName="4"; AgeType="parent"; Previous=["anne";        "mary";        "dean";        "hollie";      "joeseph";    ]}
let mallory =       { FirstName="mallory";      LastName="4"; AgeType="child";  Previous=["christopher"; "joseph";      "amie";        "james";       "mary";       ]}
let martha =        { FirstName="martha";       LastName="4"; AgeType="child";  Previous=["amie";        "julia";       "mary";        "eliz";        "christopher";]}
let mary =          { FirstName="mary";         LastName="5"; AgeType="parent"; Previous=["hollie";      "elise";       "eliz";        "andrew";      "martha";     ]}
let dean =          { FirstName="dean";         LastName="5"; AgeType="parent"; Previous=["frank";       "jimmy";       "shawn";       "martha";      "emily";      ]}
let james =         { FirstName="james";        LastName="5"; AgeType="child";  Previous=["mallory";     "christopher"; "sarah";       "elise";       "margaret";   ]}
let joeseph =       { FirstName="joeseph";      LastName="5"; AgeType="child";  Previous=["andrew";      "laura";       "julia";       "sarah";       "eliz";       ]}
let sarah =         { FirstName="sarah";        LastName="6"; AgeType="parent"; Previous=["charlie";     "margaret";    "james";       "julia";       "amie";       ]}
let shawn =         { FirstName="shawn";        LastName="6"; AgeType="parent"; Previous=["dean";        "frank";       "carla";       "jimmy";       "julia";      ]}
let sam =           { FirstName="sam";          LastName="6"; AgeType="child";  Previous=["laura";       "amie";        "joseph";      "charlie";     "andrew";      ]}
let daniel =        { FirstName="daniel";       LastName="6"; AgeType="child";  Previous=["julia";       "emily";       "margaret";    "amie";        "frank";       ]}
  

let people = [  margaret; elise; christopher; eliz; julia; //jacob;
                charlie; anne; emily; laura; tyler; 
                jimmy; hollie; andrew; megan; amie; 
                frank; carla; mallory; martha; 
                mary; dean; james; joeseph; 
                sarah; shawn; sam; daniel;                
             ]

System.Console.WriteLine("Running...");

let start = System.DateTime.Now
AssignmentGenerator.find_assignments people (1000 * 1000 * 10)
let finish = System.DateTime.Now   
System.Console.WriteLine(finish - start)



