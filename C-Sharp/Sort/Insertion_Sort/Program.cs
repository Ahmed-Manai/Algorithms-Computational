
/*
Time Complexity = O(n^2)
Best Case = O(n)
Worst Case = O(n^2)
*/


/*
[5, 9, 3, 1, 2, 8, 4, 7, 6]
    ^i
    ^j

*/


int[] Insertion_Sort(int[] tab){
    int temp;
    for (int i=0; i<tab.Length; i++) //Outer loop = O(n)
    {
        for (int j=i; j>0; j--){ //Inner loop = O(n)
            if (tab[j] < tab[j-1])
            {
                temp = tab[j];
                tab[j] = tab[j-1];
                tab[j-1] =  temp;
            }
            else 
                break;
        }
    }
    return tab;
}   


int[] in_tab = {5, 9, 3, 1, 2, 8, 4, 7, 6};
int[] out_tab = Insertion_Sort(in_tab);

Console.WriteLine("[ " + string.Join(", ", out_tab) + " ]");