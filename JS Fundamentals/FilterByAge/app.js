'use strict';

function FilterByAge([minAge,nameA, ageA, nameB, ageB]){
    let personA = {name:nameA, age:Number(ageA)};
    let personB = {name:nameB, age:Number(ageB)};
    if (personA.age>= minAge) console.log(personA);
    if (personB.age>= minAge) console.log(personB);
}

FilterByAge(['12','Ivan','15','Asen','9']);