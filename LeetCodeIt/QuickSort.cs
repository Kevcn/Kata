namespace LeetCodeIt;

public class QuickSort
{
        // A utility function to swap two elements
        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        /* This function takes last element as pivot, places
        the pivot element at its correct position in sorted
        array, and places all smaller (smaller than pivot)
        to left of pivot and all greater elements to right
        of pivot */
        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            // Index of the next item to be swapped, i + 1 at the end of the partition is the correct position for this pivot
            int i = low - 1;

            for(int j = low; j <= high - 1; j++)
            {
                // Swap if the current element is smaller than the pivot
                if (arr[j] < pivot)
                {
                    // Increment index of
                    // smaller element
                    i++;
                    Swap(arr, i, j);
                }
            }

            // move the pivot into its correct position -> i + 1
            Swap(arr, i + 1, high);
            return (i + 1);
        }

        /* The main function that implements QuickSort
		        arr[] --> Array to be sorted,
		        low --> Starting index,
		        high --> Ending index
        */
        static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // pi is partitioning index, arr[p]
                // is now at right place
                int pi = Partition(arr, low, high);

                // Separately sort elements before
                // partition and after partition
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }

        // Function to print an array
        static void printArray(int[] arr, int size)
        {
            for(int i = 0; i < size; i++)
                Console.WriteLine(arr[i] + " ");
        }

        // Driver Code
        public static void Sort()
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;

            quickSort(arr, 0, n - 1);
            Console.WriteLine("Sorted array: ");
            printArray(arr, n);
        }
    }