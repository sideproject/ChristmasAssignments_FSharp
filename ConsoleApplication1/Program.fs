// Learn more about F# at http://fsharp.net
open AssignmentGenerator
//                                                                                        2008           2009           2010           2011           2012           2013
let margaret =      { FirstName="margaret";     LastName="1"; AgeType="parent"; Previous=["mary";        "anne";        "laura";       "daniel";      "jimmy";       "martha";      ]}
let elise =         { FirstName="elise";        LastName="1"; AgeType="parent"; Previous=["james";       "hollie";      "sam";         "anne";        "megan";       "jimmy";       ]}
let christopher =   { FirstName="christopher";  LastName="1"; AgeType="child";  Previous=["shawn";       "daniel";      "anne";        "carla";       "laura";       "joeseph";     ]}
let eliz =          { FirstName="eliz";         LastName="1"; AgeType="child";  Previous=[                              "martha";      "sam";         "shawn";       "mary";        ]}
let julia =         { FirstName="julia";        LastName="1"; AgeType="child";  Previous=["carla";       "mallory";     "charlie";     "dean";        "hollie";      "anne";        ]}
//let jacob =         { FirstName="jacob";        LastName="1"; AgeType="child";  Previous=[                                                          "X"            "X"            ]}
let charlie =       { FirstName="charlie";      LastName="2"; AgeType="parent"; Previous=["jimmy";       "dean";        "hollie";      "margaret";    "elise";       "frank";       ]}
let anne =          { FirstName="anne";         LastName="2"; AgeType="parent"; Previous=["sarah";       "carla";       "christopher"; "frank";       "james";       "daniel";      ]}
let emily =         { FirstName="emily";        LastName="2"; AgeType="child";  Previous=["sam";         "james";       "andrew";      "christopher"; "dean";        "megan";       ]}
let laura =         { FirstName="laura";        LastName="2"; AgeType="child";  Previous=["martha";      "andrew";      "jimmy";       "joeseph";     "daniel";      "dean";        ]}
let tyler =         { FirstName="tyler";        LastName="2"; AgeType="child";  Previous=[                                                            "X";           "elise";       ]}
let jimmy =         { FirstName="jimmy";        LastName="3"; AgeType="parent"; Previous=["daniel";      "charlie";     "elise";       "mary";        "anne";        "emily";       ]}
let hollie =        { FirstName="hollie";       LastName="3"; AgeType="parent"; Previous=["elise";       "sarah";       "mallory";     "shawn";       "carla";       "james";       ]}
let andrew =        { FirstName="andrew";       LastName="3"; AgeType="child";  Previous=["joeseph";     "sam";         "frank";       "laura";       "sarah";       "julia";       ]}
let megan =         { FirstName="megan";        LastName="3"; AgeType="child";  Previous=[                                                            "mallory";     "eliz";        ]}
let amie =          { FirstName="amie";         LastName="3"; AgeType="child";  Previous=["emiliy";      "martha";      "emily";       "mallory";     "sam";         "carla";       ]}
let frank =         { FirstName="frank";        LastName="4"; AgeType="parent"; Previous=["margaret";    "shawn";       "daniel";      "emily";       "charlie";     "laura";       ]}
let carla =         { FirstName="carla";        LastName="4"; AgeType="parent"; Previous=["anne";        "mary";        "dean";        "hollie";      "joeseph";     "shawn";       ]}
let mallory =       { FirstName="mallory";      LastName="4"; AgeType="child";  Previous=["christopher"; "joseph";      "amie";        "james";       "mary";        "hollie";      ]}
let martha =        { FirstName="martha";       LastName="4"; AgeType="child";  Previous=["amie";        "julia";       "mary";        "eliz";        "christopher"; "sam";         ]}
let mary =          { FirstName="mary";         LastName="5"; AgeType="parent"; Previous=["hollie";      "elise";       "eliz";        "andrew";      "martha";      "tyler";       ]}
let dean =          { FirstName="dean";         LastName="5"; AgeType="parent"; Previous=["frank";       "jimmy";       "shawn";       "martha";      "emily";       "sarah";       ]}
let james =         { FirstName="james";        LastName="5"; AgeType="child";  Previous=["mallory";     "christopher"; "sarah";       "elise";       "margaret";    "amie";        ]}
let joeseph =       { FirstName="joeseph";      LastName="5"; AgeType="child";  Previous=["andrew";      "laura";       "julia";       "sarah";       "eliz";        "mallory";     ]}
let sarah =         { FirstName="sarah";        LastName="6"; AgeType="parent"; Previous=["charlie";     "margaret";    "james";       "julia";       "amie";        "andrew";      ]}
let shawn =         { FirstName="shawn";        LastName="6"; AgeType="parent"; Previous=["dean";        "frank";       "carla";       "jimmy";       "julia";       "christopher"; ]}
let sam =           { FirstName="sam";          LastName="6"; AgeType="child";  Previous=["laura";       "amie";        "joseph";      "charlie";     "andrew";      "margaret";    ]}
let daniel =        { FirstName="daniel";       LastName="6"; AgeType="child";  Previous=["julia";       "emily";       "margaret";    "amie";        "frank";       "charlie";     ]}
  

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



