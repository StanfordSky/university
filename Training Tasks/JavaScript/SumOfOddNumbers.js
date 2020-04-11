/*
Given the triangle of consecutive odd numbers:
 	           1
          3     5
       7     9    11
   13    15    17    19
21    23    25    27    29
...

Calculate the row sums of this triangle from the row index (starting at index 1) e.g.:

	rowSumOddNumbers(1); // 1
	rowSumOddNumbers(2); // 3 + 5 = 8

*/

function rowSumOddNumbers(n) {
    var fseek = 0, index = 1, result = 0;

    for(var i = 1; i<n; i++)
    {
        fseek+=i;
    }

    while(fseek != 0)
    {
        if(index % 2 == 1)
        {
            fseek--;
        }
        index++;
    }

    do{
        if(index%2==1)
        {
            result += index;
            n--;
        }
        index++;
    }while(n!=0)

  return result;
}


// Short solutions
 function rowSumOddNumbersShort(n) {
   return n*n*n;
}
