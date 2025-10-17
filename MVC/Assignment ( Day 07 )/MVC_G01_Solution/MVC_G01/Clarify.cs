namespace MVC_G01
{
    public class Clarify
    {
        // Issues
        // 1- Repeating query in controller 
        // Model >> BL Clss
        // 2- Model : Domain Models + BL 
        // Violation : Single responsibilty (SOlId)

        // Module : Model >> Domain models
        //          Repository >> Contain Operation to DB
        // Controller 









        // Refactor 02
        // Design01
        // Inline Initialization + Violation SRP
        //class Sort
        //{
        //    public void BubbleSort(int[] arr)
        //    {
        //        // arr sort in BS algorithm
        //    }
        //    public void SelectionSort(int[] arr)
        //    {
        //        // arr sort in SS algorithm
        //    }
        //}
        //class SortArr
        //{
        //    int[] arr;
        //    Sort sort = new Sort();
        //    void ExecuteSort()
        //    {
        //        sort.BubbleSort(arr);
        //    }
        //}


        // Design 02
        // extend functionality without change/modification
        // 1- violation O/C principle >> Open for extension / closed for modification
        // 2- class depend on other class
        //     High level class shouldn't depend on low level class
        //      dependency inversion >> Generalization
        //     Both Depend on ABSTRACTION 
        //     Decouple Dependency
        //class BubbleSort
        //{
        //    public void Sort(int[] arr)
        //    {
        //        // arr sort in BS algorithm
        //    }
        //}
        //class SelectionSort
        //{
        //    public void Sort(int[] arr)
        //    {
        //        // arr sort in SS algorithm
        //    }
        //}
        //class InsertionSort
        //{
        //    public void Sort(int[] arr)
        //    {
        //        // arr sort in IS algorithm
        //    }
        //}

        //class SortArr
        //{
        //    int[] arr;
        //    InsertionSort _bubbleSort;
        //    public SortArr()
        //    {
        //        _bubbleSort = new InsertionSort();
        //    }
        //    void ExecuteSort()
        //    {
        //        _bubbleSort.Sort(arr);
        //    }
        //}

        // Design 03
        interface ISort
        {
            void Sort(int[] arr);
        }
        class BubbleSort : ISort
        {
            public void Sort(int[] arr)
            {
                // arr sort in BS algorithm
            }
        }
        class SelectionSort : ISort
        {
            public void Sort(int[] arr)
            {
                // arr sort in SS algorithm
            }
        }
        class InsertionSort : ISort
        {
            public void Sort(int[] arr)
            {
                // arr sort in IS algorithm
            }
        }
        class TamerSort : ISort
        {
            public void Sort(int[] arr)
            {
                // arr sort in TS algorithm
            }
        }

        class SortArr
        {
            int[] arr;
            ISort _Sort;
            public SortArr(ISort Sort)
            {
                _Sort = Sort;
            }
            void ExecuteSort()
            {
                _Sort.Sort(arr);
            }
        }

        class TheResult
        {
            SortArr sort01 = new SortArr(new BubbleSort());
            SortArr sort02 = new SortArr(new TamerSort());
            SortArr sort03 = new SortArr(new InsertionSort());
        }

        // Clean
        // Scalable - Mainteance - testing - readable
        // SOLID :

        // Repository Design pattern 
        // How ? 
        // for each model >> class + Interface
        // why ? what? 
        // SOlid principles
        // Layer represent middleman between business logic and data source

        // Unit Of Work >> self
    }
}
}
