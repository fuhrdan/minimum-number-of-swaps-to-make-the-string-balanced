//*****************************************************************************
//** 1963. Minimum Number of Swaps to Make the String Balanced    leetcode   **
//*****************************************************************************


int minSwaps(char* s) {
    int swaps[2] = {0};
    int len = strlen(s);
    int swapCount = 0;
    for(int i = 0; i < len; i++)
    {
        int convert = s[i];
        if(convert==91)
        {
            swaps[0]++;
        }
        if(convert==93)
        {
            swaps[1]++;
        }
        if(swaps[1] > swaps[0])
        {
            swapCount++;
            swaps[1]--;
            swaps[0]++;
        }
//        printf("s[%d] = %d\n",i,convert);
    }
    return swapCount;
}