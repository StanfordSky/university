function PartsSumsVariantOne(ls) {

    let array = [], sum = 0;

    for(let i = 0; ls.length!=0; i++){
      ls.forEach(function(item, i, ls) {
        sum += item;
      });
      array.push(sum);
      sum = 0;
      ls.shift();
    }
    array.push(0);
    return array;
}

function PartsSumsVariantTwo(ls) {

    let array = [0], sum = 0;
    
    for(let i = ls.length; i>=0; i--)
    {
      sum+=ls[i];
      array.unshift(sum);
    }
    return array;
}

function PartsSumsVariantThree(ls) {

    let array = [0];
    for(let i = ls.length-1; i>=0; i--)
    {
      array.unshift(array[0]+ls[i]);
    }
    return array;
}



