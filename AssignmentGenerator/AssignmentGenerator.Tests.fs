module AssignmentGeneratorTests
open Xunit
open AssignmentGenerator

[<Fact>]
let rule_not_self_true() =
   let p1 = { FirstName="p1"; LastName="1"; AgeType="parent"; Previous=[]}
   let p2 = { FirstName="p2"; LastName="2"; AgeType="parent"; Previous=[]}
   let p3 = { FirstName="p3"; LastName="3"; AgeType="child"; Previous=[]}
   let p4 = { FirstName="p4"; LastName="4"; AgeType="child"; Previous=[]}
   
   let a1 = {From=p1; To=p2}
   let a2 = {From=p3; To=p4}
   let assignments = [a1;a2]
   Assert.True(AssignmentGenerator.rule_not_self assignments)
   

[<Fact>]
let rule_not_self_false() =
   let p1 = { FirstName="p1"; LastName="1"; AgeType="parent"; Previous=[]}
   let p2 = { FirstName="p2"; LastName="2"; AgeType="parent"; Previous=[]}
   let p3 = { FirstName="p3"; LastName="3"; AgeType="child"; Previous=[]}
   let p4 = { FirstName="p4"; LastName="4"; AgeType="child"; Previous=[]}
   
   let a1 = {From=p1; To=p1}
   let a2 = {From=p3; To=p4}
   let assignments = [a1;a2]
   Assert.False(AssignmentGenerator.rule_not_self assignments)       
    
[<Fact>]
let rule_not_same_family_true() =
   let p1 = { FirstName="p1"; LastName="1"; AgeType="parent"; Previous=[]}
   let p2 = { FirstName="p2"; LastName="1"; AgeType="parent"; Previous=[]}
   let p3 = { FirstName="p3"; LastName="2"; AgeType="child"; Previous=[]}
   let p4 = { FirstName="p4"; LastName="2"; AgeType="child"; Previous=[]}
   
   let a1 = {From=p1; To=p3}
   let a2 = {From=p2; To=p4}
   let assignments = [a1;a2]
   Assert.True(AssignmentGenerator.rule_not_same_family assignments)     
    
[<Fact>]
let rule_not_same_family_false() =
   let p1 = { FirstName="p1"; LastName="1"; AgeType="parent"; Previous=[]}
   let p2 = { FirstName="p2"; LastName="1"; AgeType="parent"; Previous=[]}
   let p3 = { FirstName="p3"; LastName="2"; AgeType="child"; Previous=[]}
   let p4 = { FirstName="p4"; LastName="2"; AgeType="child"; Previous=[]}
   
   let a1 = {From=p1; To=p2}
   let a2 = {From=p3; To=p4}
   let assignments = [a1;a2]
   Assert.False(AssignmentGenerator.rule_not_same_family assignments)    

[<Fact>]
let rule_no_previous_people_true() =
   let p1 = { FirstName="p1"; LastName="1"; AgeType="parent"; Previous=["p4"]}
   let p2 = { FirstName="p2"; LastName="2"; AgeType="parent"; Previous=["p3"]}
   let p3 = { FirstName="p3"; LastName="3"; AgeType="child"; Previous=["p1"]}
   let p4 = { FirstName="p4"; LastName="4"; AgeType="child"; Previous=["p2"]}
   
   let a1 = {From=p1; To=p2}
   let a2 = {From=p3; To=p4}
   let assignments = [a1;a2]
   Assert.True(AssignmentGenerator.rule_no_previous_people assignments)

[<Fact>]
let rule_no_previous_people_false() =
   let p1 = { FirstName="p1"; LastName="1"; AgeType="parent"; Previous=["p2"]}
   let p2 = { FirstName="p2"; LastName="2"; AgeType="parent"; Previous=["p1"]}
   let p3 = { FirstName="p3"; LastName="3"; AgeType="child"; Previous=["p7"]}
   let p4 = { FirstName="p4"; LastName="4"; AgeType="child"; Previous=["p99"]}
   
   let a1 = {From=p1; To=p2}
   let a2 = {From=p3; To=p4}
   let assignments = [a1;a2]
   Assert.False(AssignmentGenerator.rule_no_previous_people assignments)  

[<Fact>]
let rule_max_one_difficult_true() =
   let p1 =     { FirstName="p1";       LastName="1"; AgeType="parent"; Previous=[]}
   let andrew = { FirstName="andrew";   LastName="5"; AgeType="child"; Previous=[]}
   let p2 =     { FirstName="p4";       LastName="2"; AgeType="child"; Previous=[]}
   let jimmy =  { FirstName="jimmy";    LastName="5"; AgeType="parent"; Previous=[]}
   
   let a1 = {From=p1; To=andrew}
   let a2 = {From=p2; To=jimmy}
   let assignments = [a1;a2]
   Assert.True(AssignmentGenerator.rule_max_one_difficult assignments)      
   
[<Fact>]
let rule_max_one_difficult_false() =
   let p1 =     { FirstName="p1";       LastName="1"; AgeType="parent"; Previous=[]}
   let andrew = { FirstName="andrew";   LastName="5"; AgeType="child"; Previous=[]}
   let p3 =     { FirstName="p4";       LastName="1"; AgeType="child"; Previous=[]}
   let jimmy =  { FirstName="jimmy";    LastName="5"; AgeType="parent"; Previous=[]}
   
   let a1 = {From=p1; To=andrew}
   let a2 = {From=p3; To=jimmy}
   let assignments = [a1;a2]
   Assert.False(AssignmentGenerator.rule_max_one_difficult assignments)      
    
[<Fact>]
let parent_to_child_ratio_true() =
    let p1 = { FirstName="p1"; LastName="1"; AgeType="parent"; Previous=[]}
    let p2 = { FirstName="p2"; LastName="1"; AgeType="parent"; Previous=[]}
    let p3 = { FirstName="p3"; LastName="1"; AgeType="child"; Previous=[]}
    let p4 = { FirstName="p4"; LastName="1"; AgeType="child"; Previous=[]}

    let p5 = { FirstName="p5"; LastName="2"; AgeType="parent"; Previous=[]}
    let p6 = { FirstName="p6"; LastName="2"; AgeType="parent"; Previous=[]}
    let p7 = { FirstName="p7"; LastName="2"; AgeType="child"; Previous=[]}
    let p8 = { FirstName="p8"; LastName="2"; AgeType="child"; Previous=[]}

    let a1 = {From=p1; To=p5}
    let a2 = {From=p2; To=p6}
    let a3 = {From=p3; To=p7}
    let a4 = {From=p4; To=p8}
    let a5 = {From=p5; To=p1}
    let a6 = {From=p6; To=p2}
    let a7 = {From=p7; To=p3}
    let a8 = {From=p8; To=p4}
    let assignments = [a1;a2;a3;a4;a5;a6;a7;a8]

    let distinct_families = ["1"; "2"]   
    Assert.True(AssignmentGenerator.rule_good_parent_to_child_ratio assignments distinct_families)    
    
[<Fact>]
let parent_to_child_ratio_false1() =
    let p1 = { FirstName="p1"; LastName="1"; AgeType="parent"; Previous=[]}
    let p2 = { FirstName="p2"; LastName="1"; AgeType="parent"; Previous=[]}
    let p3 = { FirstName="p3"; LastName="1"; AgeType="child"; Previous=[]}
    let p4 = { FirstName="p4"; LastName="1"; AgeType="child"; Previous=[]}

    let p5 = { FirstName="p5"; LastName="2"; AgeType="parent"; Previous=[]}
    let p6 = { FirstName="p6"; LastName="2"; AgeType="parent"; Previous=[]}
    let p7 = { FirstName="p7"; LastName="2"; AgeType="child"; Previous=[]}
    let p8 = { FirstName="p8"; LastName="2"; AgeType="child"; Previous=[]}
    
    let p9 = { FirstName="p9"; LastName="3"; AgeType="child"; Previous=[]}
    let p10 = { FirstName="p10"; LastName="3"; AgeType="child"; Previous=[]}

    let a1 = {From=p1; To=p9}
    let a2 = {From=p2; To=p10}
    let a3 = {From=p3; To=p7}
    let a4 = {From=p4; To=p8}
    let a5 = {From=p5; To=p1}
    let a6 = {From=p6; To=p2}
    let a7 = {From=p7; To=p3}
    let a8 = {From=p8; To=p4}
    let assignments = [a1;a2;a3;a4;a5;a6;a7;a8] //only assigned children to family1

    let distinct_families = ["1"; "2"]   
    Assert.False(AssignmentGenerator.rule_good_parent_to_child_ratio assignments distinct_families)      

[<Fact>]
let parent_to_child_ratio_false2() =
    let p1 = { FirstName="p1"; LastName="1"; AgeType="parent"; Previous=[]}
    let p2 = { FirstName="p2"; LastName="1"; AgeType="parent"; Previous=[]}
    let p3 = { FirstName="p3"; LastName="1"; AgeType="child"; Previous=[]}
    let p4 = { FirstName="p4"; LastName="1"; AgeType="child"; Previous=[]}

    let p5 = { FirstName="p5"; LastName="2"; AgeType="parent"; Previous=[]}
    let p6 = { FirstName="p6"; LastName="2"; AgeType="parent"; Previous=[]}
    let p7 = { FirstName="p7"; LastName="2"; AgeType="child"; Previous=[]}
    let p8 = { FirstName="p8"; LastName="2"; AgeType="child"; Previous=[]}
    
    let p9 = { FirstName="p9"; LastName="3"; AgeType="parent"; Previous=[]}
    
    let a1 = {From=p1; To=p5}
    let a2 = {From=p2; To=p6}
    let a3 = {From=p3; To=p9}
    let a4 = {From=p4; To=p8}
    let a5 = {From=p5; To=p1}
    let a6 = {From=p6; To=p2}
    let a7 = {From=p7; To=p3}
    let a8 = {From=p8; To=p4}
    let assignments = [a1;a2;a3;a4;a5;a6;a7;a8] //only assigned one child to family1

    let distinct_families = ["1"; "2"]   
    Assert.False(AssignmentGenerator.rule_good_parent_to_child_ratio assignments distinct_families)      


[<Fact>]
let rule_good_family_mix_true() =
    let p1 = { FirstName="p1"; LastName="1"; AgeType="parent"; Previous=[]}
    let p2 = { FirstName="p2"; LastName="1"; AgeType="parent"; Previous=[]}
    let p3 = { FirstName="p3"; LastName="2"; AgeType="child"; Previous=[]}
    let p4 = { FirstName="p4"; LastName="2"; AgeType="child"; Previous=[]}

    let p5 = { FirstName="p5"; LastName="3"; AgeType="parent"; Previous=[]}
    let p6 = { FirstName="p6"; LastName="3"; AgeType="parent"; Previous=[]}
    let p7 = { FirstName="p7"; LastName="4"; AgeType="child"; Previous=[]}
    let p8 = { FirstName="p8"; LastName="4"; AgeType="child"; Previous=[]}

    let a1 = {From=p1; To=p5}
    let a2 = {From=p2; To=p6}
    let a3 = {From=p3; To=p7}
    let a4 = {From=p4; To=p8}
    let a5 = {From=p5; To=p1}
    let a6 = {From=p6; To=p2}
    let a7 = {From=p7; To=p3}
    let a8 = {From=p8; To=p4}
    let assignments = [a1;a2;a3;a4;a5;a6;a7;a8]

    let distinct_families = ["1"; "2"]   
    Assert.True(AssignmentGenerator.rule_good_family_mix assignments distinct_families)  
    
[<Fact>]
let rule_good_family_mix_true2() =
    let p1 = { FirstName="p1"; LastName="1"; AgeType="parent"; Previous=[]}
    let p2 = { FirstName="p2"; LastName="1"; AgeType="parent"; Previous=[]}
    let p3 = { FirstName="p3"; LastName="1"; AgeType="child"; Previous=[]}
    let p4 = { FirstName="p4"; LastName="1"; AgeType="child"; Previous=[]}
    let p14 = { FirstName="p14"; LastName="1"; AgeType="child"; Previous=[]}

    let p5 = { FirstName="p5"; LastName="2"; AgeType="parent"; Previous=[]}
    let p6 = { FirstName="p6"; LastName="2"; AgeType="parent"; Previous=[]}
    let p7 = { FirstName="p7"; LastName="2"; AgeType="child"; Previous=[]}
    let p8 = { FirstName="p8"; LastName="2"; AgeType="child"; Previous=[]}
    
    let d5 = { FirstName="d5"; LastName="8"; AgeType="parent"; Previous=[]}
    let d6 = { FirstName="d6"; LastName="8"; AgeType="parent"; Previous=[]}
    let d7 = { FirstName="d7"; LastName="8"; AgeType="child"; Previous=[]}
    let d8 = { FirstName="d8"; LastName="8"; AgeType="child"; Previous=[]}

    let a1 = {From=p1; To=p5}
    let a2 = {From=p2; To=p6}
    let a3 = {From=p3; To=p7}
    let a4 = {From=p4; To=p8}
    let a5 = {From=p14; To=d8}

    let assignments = [a1;a2;a3;a4;a5]

    let distinct_families = ["1";]   
    Assert.True(AssignmentGenerator.rule_good_family_mix assignments distinct_families)      
    
[<Fact>]
let rule_good_family_mix_false() =
    let p1 = { FirstName="p1"; LastName="1"; AgeType="parent"; Previous=[]}
    let p2 = { FirstName="p2"; LastName="1"; AgeType="parent"; Previous=[]}
    let p3 = { FirstName="p3"; LastName="1"; AgeType="child"; Previous=[]}
    let p4 = { FirstName="p4"; LastName="1"; AgeType="child"; Previous=[]}

    let p5 = { FirstName="p5"; LastName="2"; AgeType="parent"; Previous=[]}
    let p6 = { FirstName="p6"; LastName="2"; AgeType="parent"; Previous=[]}
    let p7 = { FirstName="p7"; LastName="2"; AgeType="child"; Previous=[]}
    let p8 = { FirstName="p8"; LastName="2"; AgeType="child"; Previous=[]}

    let a1 = {From=p1; To=p5}
    let a2 = {From=p2; To=p6}
    let a3 = {From=p3; To=p7}
    let a4 = {From=p4; To=p8}
    let a5 = {From=p5; To=p1}
    let a6 = {From=p6; To=p2}
    let a7 = {From=p7; To=p3}
    let a8 = {From=p8; To=p4}
    let assignments = [a1;a2;a3;a4;a5;a6;a7;a8]

    let distinct_families = ["1"; "2"]     
    Assert.False(AssignmentGenerator.rule_good_family_mix assignments distinct_families)  
    
[<Fact>]
let rule_no_previous_family_assignments_true() =
    let p1 = { FirstName="p1"; LastName="1"; AgeType="parent"; Previous=["p11"]}
    let p2 = { FirstName="p2"; LastName="1"; AgeType="parent"; Previous=["p12"]}
    let p3 = { FirstName="p3"; LastName="1"; AgeType="child"; Previous=["p13"]}
    let p4 = { FirstName="p4"; LastName="1"; AgeType="child"; Previous=["p14"]}

    let p5 = { FirstName="p5"; LastName="2"; AgeType="parent"; Previous=["p15"]}
    let p6 = { FirstName="p6"; LastName="2"; AgeType="parent"; Previous=["p16"]}
    let p7 = { FirstName="p7"; LastName="2"; AgeType="child"; Previous=["p17"]}
    let p8 = { FirstName="p8"; LastName="2"; AgeType="child"; Previous=["p18"]}

    let a1 = {From=p1; To=p5}
    let a2 = {From=p2; To=p6}
    let a3 = {From=p3; To=p7}
    let a4 = {From=p4; To=p8}
    let a5 = {From=p5; To=p1}
    let a6 = {From=p6; To=p2}
    let a7 = {From=p7; To=p3}
    let a8 = {From=p8; To=p4}
    let assignments = [a1;a2;a3;a4;a5;a6;a7;a8]

    Assert.True(AssignmentGenerator.rule_no_previous_family_assignments assignments)  

[<Fact>]
let rule_no_previous_family_assignments_false() =
    let p1 = { FirstName="p1"; LastName="1"; AgeType="parent"; Previous=["p8"]}
    let p2 = { FirstName="p2"; LastName="1"; AgeType="parent"; Previous=["p12"]}
    let p3 = { FirstName="p3"; LastName="1"; AgeType="child"; Previous=["p13"]}
    let p4 = { FirstName="p4"; LastName="1"; AgeType="child"; Previous=["p14"]}

    let p5 = { FirstName="p5"; LastName="2"; AgeType="parent"; Previous=["p15"]}
    let p6 = { FirstName="p6"; LastName="2"; AgeType="parent"; Previous=["p16"]}
    let p7 = { FirstName="p7"; LastName="2"; AgeType="child"; Previous=["p17"]}
    let p8 = { FirstName="p8"; LastName="2"; AgeType="child"; Previous=["p18"]}

    let a1 = {From=p1; To=p5}
    let a2 = {From=p2; To=p6}
    let a3 = {From=p3; To=p7}
    let a4 = {From=p4; To=p8}
    let a5 = {From=p5; To=p1}
    let a6 = {From=p6; To=p2}
    let a7 = {From=p7; To=p3}
    let a8 = {From=p8; To=p4}
    let assignments = [a1;a2;a3;a4;a5;a6;a7;a8]

    Assert.False(AssignmentGenerator.rule_no_previous_family_assignments assignments)  
    
    