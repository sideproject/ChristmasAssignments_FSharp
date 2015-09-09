// Learn more about F# at http://fsharp.net
open AssignmentGenerator
//                                                                                          2008           2009           2010           2011           2012           2013           2014           2015
let margaret =      { FirstName="margaret";     LastName="1"; AgeType="parent"; Previous=[ "mary";        "anne";        "laura";       "daniel";      "jimmy";       "martha";      "frank";       "hollie";      ]}
let elise =         { FirstName="elise";        LastName="1"; AgeType="parent"; Previous=[ "james";       "hollie";      "sam";         "anne";        "megan";       "jimmy";       "martha";      "carla";       ]}
let christopher =   { FirstName="christopher";  LastName="1"; AgeType="child";  Previous=[ "shawn";       "daniel";      "anne";        "carla";       "laura";       "joeseph";     "charlie";     "martha";      ]}
let eliz =          { FirstName="eliz";         LastName="1"; AgeType="child";  Previous=[                               "martha";      "sam";         "shawn";       "mary";        "hollie";      "james";       ]}
let julia =         { FirstName="julia";        LastName="1"; AgeType="child";  Previous=[ "carla";       "mallory";     "charlie";     "dean";        "hollie";      "anne";        "mary";        "daniel";      ]}
let jacob =         { FirstName="jacob";        LastName="1"; AgeType="child";  Previous=[                                                                            "X";           "joeseph";     "sam";         ]}
let charlie =       { FirstName="charlie";      LastName="2"; AgeType="parent"; Previous=[ "jimmy";       "dean";        "hollie";      "margaret";    "elise";       "frank";       "amie";        "mary";        ]}
let anne =          { FirstName="anne";         LastName="2"; AgeType="parent"; Previous=[ "sarah";       "carla";       "christopher"; "frank";       "james";       "daniel";      "megan";       "eliz";        ]}
let emily =         { FirstName="emily";        LastName="2"; AgeType="child";  Previous=[ "sam";         "james";       "andrew";      "christopher"; "dean";        "megan";       "carla";       "jacob";       ]}
let laura =         { FirstName="laura";        LastName="2"; AgeType="child";  Previous=[ "martha";      "andrew";      "jimmy";       "joeseph";     "daniel";      "dean";        "sam";         "sarah";       ]}
let tyler =         { FirstName="tyler";        LastName="2"; AgeType="child";  Previous=[                                                             "X";           "elise";       "dean";        "joeseph";     ]}
let jimmy =         { FirstName="jimmy";        LastName="3"; AgeType="parent"; Previous=[ "daniel";      "charlie";     "elise";       "mary";        "anne";        "emily";       "shawn";       "christopher"; ]}
let hollie =        { FirstName="hollie";       LastName="3"; AgeType="parent"; Previous=[ "elise";       "sarah";       "mallory";     "shawn";       "carla";       "james";       "laura";       "frank";       ]}
let andrew =        { FirstName="andrew";       LastName="3"; AgeType="child";  Previous=[ "joeseph";     "sam";         "frank";       "laura";       "sarah";       "julia";       "elise";       "mallory";     ]}
let megan =         { FirstName="megan";        LastName="3"; AgeType="child";  Previous=[                                                             "mallory";     "eliz";        "jacob";       "anne";        ]}
let amie =          { FirstName="amie";         LastName="3"; AgeType="child";  Previous=[ "emiliy";      "martha";      "emily";       "mallory";     "sam";         "carla";       "julia";       "elise";       ]}
let frank =         { FirstName="frank";        LastName="4"; AgeType="parent"; Previous=[ "margaret";    "shawn";       "daniel";      "emily";       "charlie";     "laura";       "christopher"; "andrew";      ]}
let carla =         { FirstName="carla";        LastName="4"; AgeType="parent"; Previous=[ "anne";        "mary";        "dean";        "hollie";      "joeseph";     "shawn";       "emily";       "amie";        ]}
let mallory =       { FirstName="mallory";      LastName="4"; AgeType="child";  Previous=[ "christopher"; "joseph";      "amie";        "james";       "mary";        "hollie";      "andrew";      "shawn";       ]}
let martha =        { FirstName="martha";       LastName="4"; AgeType="child";  Previous=[ "amie";        "julia";       "mary";        "eliz";        "christopher"; "sam";         "sarah";       "charlie";     ]}
let jordan =        { FirstName="jordan";       LastName="4"; AgeType="child";  Previous=[                                                                                                          "X";           ]}
let logan =         { FirstName="logan";        LastName="4"; AgeType="child";  Previous=[                                                                                                          "X";           ]}
let mary =          { FirstName="mary";         LastName="5"; AgeType="parent"; Previous=[ "hollie";      "elise";       "eliz";        "andrew";      "martha";      "tyler";       "daniel";      "julia";       ]}
let dean =          { FirstName="dean";         LastName="5"; AgeType="parent"; Previous=[ "frank";       "jimmy";       "shawn";       "martha";      "emily";       "sarah";       "eliz";        "margaret";    ]}
let james =         { FirstName="james";        LastName="5"; AgeType="child";  Previous=[ "mallory";     "christopher"; "sarah";       "elise";       "margaret";    "amie";        "jimmy";       "laura";       ]}
let joeseph =       { FirstName="joeseph";      LastName="5"; AgeType="child";  Previous=[ "andrew";      "laura";       "julia";       "sarah";       "eliz";        "mallory";     "margaret";    "megan";       ]}
let sarah =         { FirstName="sarah";        LastName="6"; AgeType="parent"; Previous=[ "charlie";     "margaret";    "james";       "julia";       "amie";        "andrew";      "anne";        "tyler";       ]}
let shawn =         { FirstName="shawn";        LastName="6"; AgeType="parent"; Previous=[ "dean";        "frank";       "carla";       "jimmy";       "julia";       "christopher"; "tyler";       "emily";       ]}
let sam =           { FirstName="sam";          LastName="6"; AgeType="child";  Previous=[ "laura";       "amie";        "joseph";      "charlie";     "andrew";      "margaret";    "mallory";     "dean";        ]}
let daniel =        { FirstName="daniel";       LastName="6"; AgeType="child";  Previous=[ "julia";       "emily";       "margaret";    "amie";        "frank";       "charlie";     "james";       "jimmy";       ]}





let people = [  margaret; elise; christopher; eliz; julia; jacob;
                charlie; anne; emily; laura; tyler;
                jimmy; hollie; andrew; megan; amie;
                frank; carla; mallory; martha; logan; jordan;
                mary; dean; james; joseph; 
                sarah; shawn; sam; daniel;
             ]


System.Console.WriteLine("Running...");

let start = System.DateTime.Now
AssignmentGenerator.find_assignments people (1000 * 1000 * 10)
let finish = System.DateTime.Now
System.Console.WriteLine(finish - start)



