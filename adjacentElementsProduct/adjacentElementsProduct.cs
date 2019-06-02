int adjacentElementsProduct(int[] inputArray) {
    //cant sort because we cant change order 
    int greatestProduct = 0 ;
    Boolean isGreatestEmpty = true;
    int temp;
    int arrayLength = inputArray.Length;
    for (int x = 0 ; x < arrayLength -1 ; x++)
    {
        temp = inputArray[x] * inputArray[ x+1 ];
        
        if ( isGreatestEmpty == true )
        {
             greatestProduct = temp;
            
            isGreatestEmpty = false;
            
        }
        
        else if (temp > greatestProduct){
                greatestProduct =temp;
            }
       
    }
    return greatestProduct;
}
