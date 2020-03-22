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