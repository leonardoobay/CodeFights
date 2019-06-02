int shapeArea(int n) {
     // 1 5  13  25   41
     //  4  8   12  16   
     //  
     if (n == 1){
          return 1;
     }
     else
          return (n * n) +  ( (n-1) * (n-1) );

}
