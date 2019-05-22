
int centuryFromYear(int year) {
 int remain = year % 100;
 int chopyear = year/100;
    // if remain = 0 return year /100
    // if year /100 is zero return 1 
    // if year /100 
    // if (remain <1 && remain )
    // {
    //     return  year/100;
    // }
    // else 
    // {
    //     return  (year/100)  +1 ;
    // }
   if ( chopyear == 0 )
   {
    return 1;
    // check for the first century case only 
   }
 else 
 {
  if (remain <1 )
    {
        return  year/100;
    }
    else 
    {
        return  (year/100)  +1 ;
    }
 }
}
