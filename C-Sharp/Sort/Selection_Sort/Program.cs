/*
Time Complexity = O(n^2)
*/

/* 
[5, 9, 3, 1, 2, 8, 4, 7, 6]
    ^i
       ^j
    ^min

*/
int[] Selection_Sort(int[] tab){

    int temp;
    for(int i=0; i<tab.Length-1; i++){ // Outer loop - O(n)
        int min=i; 
        for(int j=i+1; j<tab.Length; j++){ // Inner loop - O(n)
            if (tab[min] > tab[j]){
                min = j;
            }
        }
        if(min != i)
        {
            temp = tab[i];
            tab[i] = tab[min];
            tab[min] = temp;
        }
    }

    return tab;
}


int[] in_tab = {5, 9, 3, 1, 2, 8, 4, 7, 6};

int[] out_tab = Selection_Sort(in_tab);

Console.WriteLine("[ " + string.Join(", ", out_tab) + " ]");
