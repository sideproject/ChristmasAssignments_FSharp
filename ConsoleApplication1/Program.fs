// Learn more about F# at http://fsharp.net
open AssignmentGenerator
//                                                                                          2008           2009           2010           2011           2012           2013           2014
let margaret =      { FirstName="margaret";     LastName="1"; AgeType="parent"; Previous=[ "mary";        "anne";        "laura";       "daniel";      "jimmy";       "martha";      "frank";        ]}
let elise =         { FirstName="elise";        LastName="1"; AgeType="parent"; Previous=[ "james";       "hollie";      "sam";         "anne";        "megan";       "jimmy";       "martha";       ]}
let christopher =   { FirstName="christopher";  LastName="1"; AgeType="child";  Previous=[ "shawn";       "daniel";      "anne";        "carla";       "laura";       "joseph";      "charlie";      ]}
let eliz =          { FirstName="eliz";         LastName="1"; AgeType="child";  Previous=[                               "martha";      "sam";         "shawn";       "mary";        "hollie";       ]}
let julia =         { FirstName="julia";        LastName="1"; AgeType="child";  Previous=[ "carla";       "mallory";     "charlie";     "dean";        "hollie";      "anne";        "mary";         ]}
let jacob =         { FirstName="jacob";        LastName="1"; AgeType="child";  Previous=[                                                                            "X";           "joseph";       ]}
let charlie =       { FirstName="charlie";      LastName="2"; AgeType="parent"; Previous=[ "jimmy";       "dean";        "hollie";      "margaret";    "elise";       "frank";       "amie";         ]}
let anne =          { FirstName="anne";         LastName="2"; AgeType="parent"; Previous=[ "sarah";       "carla";       "christopher"; "frank";       "james";       "daniel";      "megan";        ]}
let emily =         { FirstName="emily";        LastName="2"; AgeType="child";  Previous=[ "sam";         "james";       "andrew";      "christopher"; "dean";        "megan";       "carla";        ]}
let laura =         { FirstName="laura";        LastName="2"; AgeType="child";  Previous=[ "martha";      "andrew";      "jimmy";       "joseph";      "daniel";      "dean";        "sam";          ]}
let tyler =         { FirstName="tyler";        LastName="2"; AgeType="child";  Previous=[                                                             "X";           "elise";       "andrew";       ]}
let jimmy =         { FirstName="jimmy";        LastName="3"; AgeType="parent"; Previous=[ "daniel";      "charlie";     "elise";       "mary";        "anne";        "emily";       "shawn";        ]}
let hollie =        { FirstName="hollie";       LastName="3"; AgeType="parent"; Previous=[ "elise";       "sarah";       "mallory";     "shawn";       "carla";       "james";       "laura";        ]}
let andrew =        { FirstName="andrew";       LastName="3"; AgeType="child";  Previous=[ "joseph";      "sam";         "frank";       "laura";       "sarah";       "julia";       "elise";        ]}
let megan =         { FirstName="megan";        LastName="3"; AgeType="child";  Previous=[                                                             "mallory";     "eliz";        "jacob";        ]}
let amie =          { FirstName="amie";         LastName="3"; AgeType="child";  Previous=[ "emiliy";      "martha";      "emily";       "mallory";     "sam";         "carla";       "julia";        ]}
let frank =         { FirstName="frank";        LastName="4"; AgeType="parent"; Previous=[ "margaret";    "shawn";       "daniel";      "emily";       "charlie";     "laura";       "christopher";  ]}
let carla =         { FirstName="carla";        LastName="4"; AgeType="parent"; Previous=[ "anne";        "mary";        "dean";        "hollie";      "joseph";      "shawn";       "emily";        ]}
let mallory =       { FirstName="mallory";      LastName="4"; AgeType="child";  Previous=[ "christopher"; "joseph";      "amie";        "james";       "mary";        "hollie";      "dean";         ]}
let martha =        { FirstName="martha";       LastName="4"; AgeType="child";  Previous=[ "amie";        "julia";       "mary";        "eliz";        "christopher"; "sam";         "sarah";        ]}
let mary =          { FirstName="mary";         LastName="5"; AgeType="parent"; Previous=[ "hollie";      "elise";       "eliz";        "andrew";      "martha";      "tyler";       "daniel";       ]}
let dean =          { FirstName="dean";         LastName="5"; AgeType="parent"; Previous=[ "frank";       "jimmy";       "shawn";       "martha";      "emily";       "sarah";       "eliz";         ]}
let james =         { FirstName="james";        LastName="5"; AgeType="child";  Previous=[ "mallory";     "christopher"; "sarah";       "elise";       "margaret";    "amie";        "jimmy";        ]}
let joseph =        { FirstName="joseph";       LastName="5"; AgeType="child";  Previous=[ "andrew";      "laura";       "julia";       "sarah";       "eliz";        "mallory";     "margaret";     ]}
let sarah =         { FirstName="sarah";        LastName="6"; AgeType="parent"; Previous=[ "charlie";     "margaret";    "james";       "julia";       "amie";        "andrew";      "anne";         ]}
let shawn =         { FirstName="shawn";        LastName="6"; AgeType="parent"; Previous=[ "dean";        "frank";       "carla";       "jimmy";       "julia";       "christopher"; "tyler";        ]}
let sam =           { FirstName="sam";          LastName="6"; AgeType="child";  Previous=[ "laura";       "amie";        "joseph";      "charlie";     "andrew";      "margaret";    "mallory";      ]}
let daniel =        { FirstName="daniel";       LastName="6"; AgeType="child";  Previous=[ "julia";       "emily";       "margaret";    "amie";        "frank";       "charlie";     "james";        ]}
   

let people = [  margaret; elise; christopher; eliz; julia; jacob;
                charlie; anne; emily; laura; tyler; 
                jimmy; hollie; andrew; megan; amie; 
                frank; carla; mallory; martha; 
                mary; dean; james; joseph; 
                sarah; shawn; sam; daniel;                
             ]

System.Console.WriteLine("Running...");

let start = System.DateTime.Now
AssignmentGenerator.find_assignments people (1000 * 1000 * 10)
let finish = System.DateTime.Now   
System.Console.WriteLine(finish - start)



