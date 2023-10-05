/*
Time Complexity = O(n^2)
Best Case = O(n) 
Wost Case = O(n^2)
*/


// [5, 9, 3, 1, 2, 8, 4, 7, 6]
//                       ^i
//                          ^j

int[] Bubble_Sort(int[] tab){
    int temp;
    bool swapped;
    for (int i= 0; i<tab.Length -1 ; i++){ // Outer loop - O(n)
        swapped = false;
        for (int j=tab.Length-1; j>i; j--){ // Inner loop - O(n)
            if (tab[j] < tab[j-1]){
                temp =tab[j];
                tab[j] = tab[j-1];
                tab[j-1] = temp;
                swapped = true;
            }
        }
        if (!swapped){
            break;
        }
    }
    return tab;
}

int[] in_tab = {5, 9, 3, 1, 2, 8, 4, 7, 6};

int[] out_tab = Bubble_Sort(in_tab);

Console.WriteLine("[ " + string.Join(", ", out_tab) + " ]");
