int makeArrayConsecutive2(int[] statues) {
    // array 6. 2. 3  8 
    // once sorted  2. 3. 6. 8 
    // look thru the loop 
    // increment based on differences minus 1
    InsertionSort(statues);
    int  statueSize = statues.Length;
    int  missingStatues = 0 ;
    for (int x = 0 ; x < statueSize -1; x++)
    {
        // if (statues[x+1] - statues[x] >= 2)
        // {
           missingStatues += (statues[x+1] - statues[x]) -1 ;
        // }
        
    }
    return missingStatues;

}

 static int[] InsertionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                  }
            }
            return inputArray;         
        }

