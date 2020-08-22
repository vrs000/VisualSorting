using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace WPF_sandobx
{
    public class VisualSort
    {
        private SortType SortKey;
        private SortOrder OrderKey;
        UIElementCollection elements;

        public VisualSort(SortType _SortKey, SortOrder _OrderKey)
        {
            SortKey = _SortKey;
            OrderKey = _OrderKey;
        }



    }

    public static class SORT
    {
        private static double d;
        public static int TicksDelay = 10000;

        public async static Task InsertionSort(UIElementCollection list, SortOrder key)
        {
            //double d;

            if (key == SortOrder.Ascedning)
            {

                for (int i = 1; i < list.Count; i++)
                    for (int j = i; j > 0 && (list[j - 1] as Rectangle).Height > (list[j] as Rectangle).Height; j--)
                    {

                        //await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay / 2));
                        ElementsSelectionConf.Select(list[j - 1] as Rectangle, list[j] as Rectangle);
                        await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay));


                        d = (list[j - 1] as Rectangle).Height;
                        (list[j - 1] as Rectangle).Height = (list[j] as Rectangle).Height;
                        (list[j] as Rectangle).Height = d;


                        ElementsSelectionConf.Back(list[j - 1] as Rectangle, list[j] as Rectangle);
                    }
            }

            if (key == SortOrder.Descending)
            {
                for (int i = 1; i < list.Count; i++)
                    for (int j = i; j > 0 && (list[j - 1] as Rectangle).Height < (list[j] as Rectangle).Height; j--)
                    {
                        await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay / 2));
                        ElementsSelectionConf.Select(list[j - 1] as Rectangle, list[j] as Rectangle);
                        await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay));

                        d = (list[j - 1] as Rectangle).Height;
                        (list[j - 1] as Rectangle).Height = (list[j] as Rectangle).Height;
                        (list[j] as Rectangle).Height = d;


                        ElementsSelectionConf.Back(list[j - 1] as Rectangle, list[j] as Rectangle);
                    }
            }
        }

        public async static Task QuickSort(UIElementCollection A, SortOrder key, int L, int R)
        {
            if (key == SortOrder.Ascedning)
            {

                int i, j;
                double x, y;
                i = L; j = R;
                x = (A[(L + R) / 2] as Rectangle).Height;

                (A[(L + R) / 2] as Rectangle).Fill = ElementsSelectionConf.SelectedColor;
                (A[(L + R) / 2] as Rectangle).Stroke = ElementsSelectionConf.SelectedColor;


                //(A[i] as Rectangle).Height

                do
                {
                    while ((A[i] as Rectangle).Height < x) i++;
                    while (x < (A[j] as Rectangle).Height) j--;

                    if (i <= j)
                    {
                        await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay / 2));
                        ElementsSelectionConf.Select(A[i] as Rectangle, A[j] as Rectangle);
                        await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay));


                        y = (A[i] as Rectangle).Height;
                        (A[i] as Rectangle).Height = (A[j] as Rectangle).Height;
                        (A[j] as Rectangle).Height = y;

                        ElementsSelectionConf.Back(A[i] as Rectangle, A[j] as Rectangle);
                        i++; j--;
                    }

                } while (i <= j);//Мб ошибка

                (A[(L + R) / 2] as Rectangle).Fill = ElementsSelectionConf.FillElements;
                (A[(L + R) / 2] as Rectangle).Stroke = ElementsSelectionConf.StrokeColor;

                if (L < j)
                    await QuickSort(A, SortOrder.Ascedning, L, j);
                if (i < R)
                    await QuickSort(A, SortOrder.Ascedning, i, R);

            }

            if (key == SortOrder.Descending)
            {
                int i, j;
                double x, y;
                i = L; j = R;
                x = (A[(L + R) / 2] as Rectangle).Height;

                (A[(L + R) / 2] as Rectangle).Fill = ElementsSelectionConf.SelectedColor;
                (A[(L + R) / 2] as Rectangle).Stroke = ElementsSelectionConf.SelectedColor;


                //(A[i] as Rectangle).Height

                do
                {
                    while ((A[i] as Rectangle).Height > x) i++;
                    while (x > (A[j] as Rectangle).Height) j--;

                    if (i <= j)
                    {
                        await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay / 2));
                        ElementsSelectionConf.Select(A[i] as Rectangle, A[j] as Rectangle);
                        await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay));


                        y = (A[i] as Rectangle).Height;
                        (A[i] as Rectangle).Height = (A[j] as Rectangle).Height;
                        (A[j] as Rectangle).Height = y;

                        ElementsSelectionConf.Back(A[i] as Rectangle, A[j] as Rectangle);
                        i++; j--;
                    }

                } while (i <= j);//Мб ошибка

                (A[(L + R) / 2] as Rectangle).Fill = ElementsSelectionConf.FillElements;
                (A[(L + R) / 2] as Rectangle).Stroke = ElementsSelectionConf.StrokeColor;

                if (L < j)
                    await QuickSort(A, SortOrder.Descending, L, j);
                if (i < R)
                    await QuickSort(A, SortOrder.Descending, i, R);
            }

        }

        public async static Task GnomeSort(UIElementCollection a, SortOrder key)
        {
            if (key == SortOrder.Ascedning)
            {

                //(a[i] as Rectangle).Height
                //(a[i-1] as Rectangle).Height
                int i = 1; double tmp;

                while (i < a.Count) if (i == 0 || (a[i - 1] as Rectangle).Height <= (a[i] as Rectangle).Height) i++;

                    else

                    {

                        await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay / 2));
                        ElementsSelectionConf.Select(a[i] as Rectangle, a[i - 1] as Rectangle);
                        await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay));


                        tmp = (a[i] as Rectangle).Height;
                        (a[i] as Rectangle).Height = (a[i - 1] as Rectangle).Height;
                        (a[i - 1] as Rectangle).Height = tmp;

                        ElementsSelectionConf.Back(a[i] as Rectangle, a[i - 1] as Rectangle);


                        i--;
                    }


            }

            if (key == SortOrder.Descending)
            {
                int i = 1; double tmp;

                while (i < a.Count) if (i == 0 || (a[i - 1] as Rectangle).Height >= (a[i] as Rectangle).Height) i++;

                    else

                    {

                        await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay / 2));
                        ElementsSelectionConf.Select(a[i] as Rectangle, a[i - 1] as Rectangle);
                        await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay));


                        tmp = (a[i] as Rectangle).Height;
                        (a[i] as Rectangle).Height = (a[i - 1] as Rectangle).Height;
                        (a[i - 1] as Rectangle).Height = tmp;

                        ElementsSelectionConf.Back(a[i] as Rectangle, a[i - 1] as Rectangle);


                        i--;
                    }

            }
        }

        static async Task Merge(UIElementCollection A, int first, int last)
        {
            int middle, start, final, j;
            List<Rectangle> mas = new List<Rectangle>();
            for (int k = 0; k < A.Count; k++) mas.Add(new Rectangle());
            middle = (first + last) / 2;
            start = first;
            final = middle + 1;

            for (j = first; j <= last; j++)
                if ((start <= middle) && ((final > last) || ((A[start] as Rectangle).Height < (A[final] as Rectangle).Height)))
                {
                    try
                    {
                        ElementsSelectionConf.SelectBack(A[start] as Rectangle, A[final] as Rectangle);
                    }
                    catch (Exception)
                    {

                    }
                    mas[j].Height = (A[start] as Rectangle).Height;
                    start++;
                }
                else
                {
                    //await ElementsSelectionConf.SelectBack(A[start] as Rectangle, A[final] as Rectangle);
                    try
                    {
                        ElementsSelectionConf.SelectBack(A[start] as Rectangle, A[final] as Rectangle);
                    }
                    catch (Exception)
                    {

                    }
                    mas[j].Height = (A[final] as Rectangle).Height;
                    final++;
                }
            for (j = first; j <= last; j++)
            {
                (A[j] as Rectangle).Fill = ElementsSelectionConf.SelectedColor;
                (A[j] as Rectangle).Stroke = ElementsSelectionConf.SelectedColor;
                await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay));
                (A[j] as Rectangle).Height = mas[j].Height;
                (A[j] as Rectangle).Fill = ElementsSelectionConf.FillElements;
                (A[j] as Rectangle).Stroke = ElementsSelectionConf.StrokeColor;
            }

        }

        static async Task Merge1(UIElementCollection A, int first, int last)
        {
            int middle, start, final, j;
            List<Rectangle> mas = new List<Rectangle>();
            for (int k = 0; k < A.Count; k++) mas.Add(new Rectangle());
            middle = (first + last) / 2;
            start = first;
            final = middle + 1;

            for (j = first; j <= last; j++)
                if ((start <= middle) && ((final > last) || ((A[start] as Rectangle).Height > (A[final] as Rectangle).Height)))
                {
                    try
                    {
                        ElementsSelectionConf.SelectBack(A[start] as Rectangle, A[final] as Rectangle);
                    }
                    catch (Exception)
                    {

                    }
                    mas[j].Height = (A[start] as Rectangle).Height;
                    start++;
                }
                else
                {
                    try
                    {
                        ElementsSelectionConf.SelectBack(A[start] as Rectangle, A[final] as Rectangle);
                    }
                    catch (Exception)
                    {

                    }
                    mas[j].Height = (A[final] as Rectangle).Height;
                    final++;
                }
            for (j = first; j <= last; j++)
            {
                (A[j] as Rectangle).Fill = ElementsSelectionConf.SelectedColor;
                (A[j] as Rectangle).Stroke = ElementsSelectionConf.SelectedColor;
                await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay));

                (A[j] as Rectangle).Height = mas[j].Height;

                (A[j] as Rectangle).Fill = ElementsSelectionConf.FillElements;
                (A[j] as Rectangle).Stroke = ElementsSelectionConf.StrokeColor;
            }

        }

        public async static Task MergeSort(UIElementCollection Collection, SortOrder key, int first, int last)
        {
            if (key == SortOrder.Ascedning)
            {
                if (first < last)
                {

                    //await MergeSort(Collection, SortOrder.Ascedning, first, (first + last) / 2);
                    //await MergeSort(Collection, SortOrder.Ascedning, (first + last) / 2 + 1, last);
                    //await Merge(Collection, first, last);

                    await MergeSort(Collection, SortOrder.Ascedning, first, (first + last) / 2);
                    await MergeSort(Collection, SortOrder.Ascedning, (first + last) / 2 + 1, last);
                    await Merge(Collection, first, last);
                }
            }

            if (key == SortOrder.Descending)
            {
                if (first < last)
                {

                    await MergeSort(Collection, SortOrder.Descending, first, (first + last) / 2);
                    await MergeSort(Collection, SortOrder.Descending, (first + last) / 2 + 1, last);
                    await Merge1(Collection, first, last);
                }
            }

        }

        public async static Task ShellSort(UIElementCollection array, SortOrder key)
        {
            if (key == SortOrder.Ascedning)
            {
                int step, i, j, size = array.Count;
                double tmp;


                for (step = size / 2; step > 0; step /= 2)
                    for (i = step; i < size; i++)
                        for (j = i - step; j >= 0 && (array[j] as Rectangle).Height > (array[j + step] as Rectangle).Height; j -= step)
                        {
                            ElementsSelectionConf.Select(array[j] as Rectangle, array[j + step] as Rectangle);
                            await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay));

                            tmp = (array[j] as Rectangle).Height;
                            (array[j] as Rectangle).Height = (array[j + step] as Rectangle).Height;
                            (array[j + step] as Rectangle).Height = tmp;

                            ElementsSelectionConf.Back(array[j] as Rectangle, array[j + step] as Rectangle);
                        }
            }

            if (key == SortOrder.Descending)
            {
                int step, i, j, size = array.Count;
                double tmp;


                for (step = size / 2; step > 0; step /= 2)
                    for (i = step; i < size; i++)
                        for (j = i - step; j >= 0 && (array[j] as Rectangle).Height < (array[j + step] as Rectangle).Height; j -= step)
                        {
                            ElementsSelectionConf.Select(array[j] as Rectangle, array[j + step] as Rectangle);
                            await Task.Delay(TimeSpan.FromTicks(SORT.TicksDelay));

                            tmp = (array[j] as Rectangle).Height;
                            (array[j] as Rectangle).Height = (array[j + step] as Rectangle).Height;
                            (array[j + step] as Rectangle).Height = tmp;

                            ElementsSelectionConf.Back(array[j] as Rectangle, array[j + step] as Rectangle);
                        }
            }
        }

        public static async Task SelectionSort(UIElementCollection a, SortOrder key)
        {

            if (key == SortOrder.Ascedning)
            {
                int i, j, k;
                double x;
                int size = a.Count;

                for (i = 0; i < size; i++)
                {       // i - номер текущего шага
                    k = i; x = (a[i] as Rectangle).Height;

                    for (j = i + 1; j < size; j++)  // цикл выбора наименьшего элемента
                        if ((a[j] as Rectangle).Height < x)
                        {
                            k = j; x = (a[j] as Rectangle).Height;            // k - индекс наименьшего элемента
                        }
                    await ElementsSelectionConf.SelectBack(a[k] as Rectangle, a[i] as Rectangle);
                    (a[k] as Rectangle).Height = (a[i] as Rectangle).Height;
                    (a[i] as Rectangle).Height = x;
                }
            }

            if (key == SortOrder.Descending)
            {
                int i, j, k;
                double x;
                int size = a.Count;

                for (i = 0; i < size; i++)
                {       // i - номер текущего шага
                    k = i; x = (a[i] as Rectangle).Height;

                    for (j = i + 1; j < size; j++)  // цикл выбора наименьшего элемента
                        if ((a[j] as Rectangle).Height > x)
                        {
                            k = j; x = (a[j] as Rectangle).Height;            // k - индекс наименьшего элемента
                        }
                    await ElementsSelectionConf.SelectBack(a[k] as Rectangle, a[i] as Rectangle);
                    (a[k] as Rectangle).Height = (a[i] as Rectangle).Height;
                    (a[i] as Rectangle).Height = x;
                }
            }



        }

        //public static void CombSort(ref int[] data)
        //{
        //    double gap = data.Length;
        //    bool swaps = true;

        //    while (gap > 1 || swaps)
        //    {
        //        gap /= 1.247330950103979;

        //        if (gap < 1)
        //            gap = 1;

        //        int i = 0;
        //        swaps = false;

        //        while (i + gap < data.Length)
        //        {
        //            int igap = i + (int)gap;

        //            if (data[i] > data[igap])
        //            {
        //                int temp = data[i];
        //                data[i] = data[igap];
        //                data[igap] = temp;
        //                swaps = true;
        //            }

        //            ++i;
        //        }
        //    }
        //}

        public static async Task ComboSort(UIElementCollection data, SortOrder key)
        {
            if (key == SortOrder.Ascedning)
            {
                double gap = data.Count;
                bool swaps = true;

                while (gap > 1 || swaps)
                {
                    gap /= 1.247330950103979;

                    if (gap < 1)
                        gap = 1;

                    int i = 0;
                    swaps = false;

                    while (i + gap < data.Count)
                    {
                        int igap = i + (int)gap;

                        if (((Rectangle)data[i]).Height > ((Rectangle)data[igap]).Height)
                        {
                            await ElementsSelectionConf.SelectBack(data[i] as Rectangle, data[igap] as Rectangle);
                            double temp = ((Rectangle)data[i]).Height;
                            ((Rectangle)data[i]).Height = ((Rectangle)data[igap]).Height;
                            ((Rectangle)data[igap]).Height = temp;
                            swaps = true;
                        }

                        ++i;
                    }
                }
            }

            if (key == SortOrder.Descending)
            {
                double gap = data.Count;
                bool swaps = true;

                while (gap > 1 || swaps)
                {
                    gap /= 1.247330950103979;

                    if (gap < 1)
                        gap = 1;

                    int i = 0;
                    swaps = false;

                    while (i + gap < data.Count)
                    {
                        int igap = i + (int)gap;

                        if (((Rectangle)data[i]).Height < ((Rectangle)data[igap]).Height)
                        {
                            await ElementsSelectionConf.SelectBack(data[i] as Rectangle, data[igap] as Rectangle);
                            double temp = ((Rectangle)data[i]).Height;
                            ((Rectangle)data[i]).Height = ((Rectangle)data[igap]).Height;
                            ((Rectangle)data[igap]).Height = temp;
                            swaps = true;
                        }

                        ++i;
                    }
                }
            }
        }


        static async Task<int> add2pyramid(UIElementCollection arr, Int32 i, Int32 N)
        {
            Int32 imax;
            double buf;
            if ((2 * i + 2) < N)
            {
                if ((arr[2 * i + 1] as Rectangle).Height < (arr[2 * i + 2] as Rectangle).Height)
                {
                    //await ElementsSelectionConf.SelectBack(arr[2 * i + 1] as Rectangle, arr[2 * i + 2] as Rectangle);
                    imax = 2 * i + 2;
                }
                else imax = 2 * i + 1;
            }
            else imax = 2 * i + 1;
            if (imax >= N)
                return i;

            if ((arr[i] as Rectangle).Height < (arr[imax] as Rectangle).Height)
            {
                await ElementsSelectionConf.SelectBack(arr[imax] as Rectangle, arr[i] as Rectangle);

                buf = (arr[i] as Rectangle).Height;
                (arr[i] as Rectangle).Height = (arr[imax] as Rectangle).Height;
                (arr[imax] as Rectangle).Height = buf;

                if (imax < N / 2) i = imax;
            }
            return i;
        }


        static async Task<int> add2pyramid_(UIElementCollection arr, Int32 i, Int32 N)
        {
            Int32 imax;
            double buf;
            if ((2 * i + 2) < N)
            {
                if ((arr[2 * i + 1] as Rectangle).Height > (arr[2 * i + 2] as Rectangle).Height)
                {
                    //await ElementsSelectionConf.SelectBack(arr[2 * i + 1] as Rectangle, arr[2 * i + 2] as Rectangle);
                    imax = 2 * i + 2;
                }
                else imax = 2 * i + 1;
            }
            else imax = 2 * i + 1;
            if (imax >= N)
                return i;

            if ((arr[i] as Rectangle).Height > (arr[imax] as Rectangle).Height)
            {
                await ElementsSelectionConf.SelectBack(arr[imax] as Rectangle, arr[i] as Rectangle);

                buf = (arr[i] as Rectangle).Height;
                (arr[i] as Rectangle).Height = (arr[imax] as Rectangle).Height;
                (arr[imax] as Rectangle).Height = buf;

                if (imax < N / 2) i = imax;
            }
            return i;
        }

        public static async Task Pyramid_Sort(UIElementCollection arr, SortOrder key)
        {
            if (key == SortOrder.Ascedning)
            {
                int len = arr.Count;
                //step 1: building the pyramid
                for (Int32 i = len / 2 - 1; i >= 0; --i)
                {
                    long prev_i = i;
                    i = Convert.ToInt32(await add2pyramid(arr, i, len));
                    if (prev_i != i) ++i;
                }

                //step 2: sorting
                double buf;
                for (Int32 k = len - 1; k > 0; --k)
                {
                    await ElementsSelectionConf.SelectBack(arr[0] as Rectangle, arr[k] as Rectangle);
                    buf = (arr[0] as Rectangle).Height;
                    (arr[0] as Rectangle).Height = (arr[k] as Rectangle).Height;
                    (arr[k] as Rectangle).Height = buf;
                    Int32 i = 0, prev_i = -1;
                    while (i != prev_i)
                    {
                        prev_i = i;
                        i = Convert.ToInt32(await add2pyramid(arr, i, k));
                    }
                }
            }


            if (key == SortOrder.Descending)
            {
                int len = arr.Count;
                //step 1: building the pyramid
                for (Int32 i = len / 2 - 1; i >= 0; --i)
                {
                    long prev_i = i;
                    i = Convert.ToInt32(await add2pyramid_(arr, i, len));
                    if (prev_i != i) ++i;
                }

                //step 2: sorting
                double buf;
                for (Int32 k = len - 1; k > 0; --k)
                {
                    await ElementsSelectionConf.SelectBack(arr[0] as Rectangle, arr[k] as Rectangle);
                    buf = (arr[0] as Rectangle).Height;
                    (arr[0] as Rectangle).Height = (arr[k] as Rectangle).Height;
                    (arr[k] as Rectangle).Height = buf;
                    Int32 i = 0, prev_i = -1;
                    while (i != prev_i)
                    {
                        prev_i = i;
                        i = Convert.ToInt32(await add2pyramid_(arr, i, k));
                    }
                }
            }


        }


        public static async Task StoogeSort(UIElementCollection item, int left, int right, SortOrder key)
        {
            if (key == SortOrder.Ascedning)
            {
                double tmp;
                int k;
                if ((item[left] as Rectangle).Height > (item[right] as Rectangle).Height)
                {
                    await ElementsSelectionConf.SelectBack(item[left] as Rectangle, item[right] as Rectangle);

                    tmp = (item[left] as Rectangle).Height;
                    (item[left] as Rectangle).Height = (item[right] as Rectangle).Height;
                    (item[right] as Rectangle).Height = tmp;
                }
                if ((left + 1) >= right)
                    return;

                k = (int)((right - left + 1) / 3);
                await StoogeSort(item, left, right - k, key);
                await StoogeSort(item, left + k, right, key);
                await StoogeSort(item, left, right - k, key);
            }

            if (key == SortOrder.Descending)
            {
                double tmp;
                int k;
                if ((item[left] as Rectangle).Height < (item[right] as Rectangle).Height)
                {
                    await ElementsSelectionConf.SelectBack(item[left] as Rectangle, item[right] as Rectangle);

                    tmp = (item[left] as Rectangle).Height;
                    (item[left] as Rectangle).Height = (item[right] as Rectangle).Height;
                    (item[right] as Rectangle).Height = tmp;
                }
                if ((left + 1) >= right)
                    return;

                k = (int)((right - left + 1) / 3);
                await StoogeSort(item, left, right - k, key);
                await StoogeSort(item, left + k, right, key);
                await StoogeSort(item, left, right - k, key);
            }

        }

        #region
        static async Task<bool> correct(UIElementCollection arr, int size)
        {
            while (size-- > 0)
                if ((arr[size - 1] as Rectangle).Height > (arr[size] as Rectangle).Height)
                    return false;
            return true;
        }

        static Random rand = new Random();
        static async Task shuffle(UIElementCollection arr, int size)
        {
            double tmp;
            int k;
            for (int i = 0; i < size; ++i)
            {
                k = rand.Next(Int32.MaxValue) % size;

                await ElementsSelectionConf.SelectBack(arr[i] as Rectangle, arr[k] as Rectangle);


                tmp = (arr[i] as Rectangle).Height;
                (arr[i] as Rectangle).Height = (arr[k] as Rectangle).Height;
                (arr[k] as Rectangle).Height = tmp;
                //swap(arr[i], arr[(rand() % size)]);
            }
        }
        #endregion


        //метод для проверки упорядоченности массива
        static bool IsSorted(UIElementCollection a)
        {
            for (int i = 0; i < a.Count - 1; i++)
            {
                if ((a[i] as Rectangle).Height > (a[i + 1] as Rectangle).Height)
                    return false;
            }

            return true;
        }

        static bool IsSorted_(UIElementCollection a)
        {
            for (int i = 0; i < a.Count - 1; i++)
            {
                if ((a[i] as Rectangle).Height < (a[i + 1] as Rectangle).Height)
                    return false;
            }

            return true;
        }

        //перемешивание элементов массива
        static async Task RandomPermutation(UIElementCollection a)
        {
            Random random = new Random();
            var n = a.Count;
            while (n > 1)
            {
                n--;
                var i = random.Next(n + 1);

                await ElementsSelectionConf.SelectBack(a[i] as Rectangle, a[n] as Rectangle);

                var temp = (a[i] as Rectangle).Height;
                (a[i] as Rectangle).Height = (a[n] as Rectangle).Height;
                (a[n] as Rectangle).Height = temp;
            }


        }

        //случайная сортировка
        //public static async Task BogoSort(UIElementCollection a)
        // {
        //     while (!IsSorted(a))
        //     {
        //         await RandomPermutation(a);
        //     }


        // }



        public static async Task BogoSort(UIElementCollection a, SortOrder key)
        {
            if (key == SortOrder.Ascedning)
            {
                //while (!Convert.ToBoolean(await correct(arr, arr.Count)))
                //    await shuffle(arr, arr.Count);

                while (!IsSorted(a))
                {
                    await RandomPermutation(a);
                }


            }

            if (key == SortOrder.Descending)
            {
                while (!IsSorted_(a))
                {
                    await RandomPermutation(a);
                }
            }

        }


        static async Task<int> Partition(UIElementCollection data, int left, int right)
        {
            double pivot = (data[right] as Rectangle).Height;
            double temp;
            int i = left;

            for (int j = left; j < right; ++j)
            {
                if ((data[j] as Rectangle).Height <= pivot)
                {
                    await ElementsSelectionConf.SelectBack(data[j] as Rectangle, data[i] as Rectangle);

                    temp = (data[j] as Rectangle).Height;
                    (data[j] as Rectangle).Height = (data[i] as Rectangle).Height;
                    (data[i] as Rectangle).Height = temp;
                    i++;
                }
            }

            await ElementsSelectionConf.SelectBack(data[right] as Rectangle, data[i] as Rectangle);

            (data[right] as Rectangle).Height = (data[i] as Rectangle).Height;
            (data[i] as Rectangle).Height = pivot;

            return i;
        }

        public static async Task IntroSort(UIElementCollection data, SortOrder key)
        {
            int partitionSize = Convert.ToInt32(await Partition(data, 0, data.Count - 1));

            if (partitionSize < 16)
            {
                await InsertionSort(data, key);
            }
            else if (partitionSize > (2 * Math.Log(data.Count)))
            {
                await Pyramid_Sort(data, key);
            }
            else
            {
                await QuickSort(data, key, 0, data.Count - 1);
            }
        }

        //public static async Task PancakeSort<T>(UIElementCollection arr, int cutoffValue = 2)

        public static async Task PancakeSort(UIElementCollection arr, SortOrder key)

        {
            if (key == SortOrder.Ascedning)
            {
                for (int i = arr.Count - 1; i >= 0; --i)
                {
                    int pos = i;
                    // Find position of max number between beginning and i
                    for (int j = 0; j < i; j++)
                    {
                        if ((arr[j] as Rectangle).Height > (arr[pos] as Rectangle).Height)
                        {
                            pos = j;
                        }
                    }

                    // is it in the correct position already? 
                    if (pos == i)
                    {
                        continue;
                    }

                    // is it at the beginning of the array? If not flip array section so it is
                    if (pos != 0)
                    {
                        await Flip(arr, pos + 1);
                    }

                    // Flip array section to get max number to correct position    
                    await Flip(arr, i + 1);
                }
            }

            if (key == SortOrder.Descending)
            {
                for (int i = arr.Count - 1; i >= 0; --i)
                {
                    int pos = i;
                    // Find position of max number between beginning and i
                    for (int j = 0; j < i; j++)
                    {
                        if ((arr[j] as Rectangle).Height < (arr[pos] as Rectangle).Height)
                        {
                            pos = j;
                        }
                    }

                    // is it in the correct position already? 
                    if (pos == i)
                    {
                        continue;
                    }

                    // is it at the beginning of the array? If not flip array section so it is
                    if (pos != 0)
                    {
                        await Flip(arr, pos + 1);
                    }

                    // Flip array section to get max number to correct position    
                    await Flip(arr, i + 1);
                }
            }



        }

        static async Task Flip(UIElementCollection arr, int n)

        {
            for (int i = 0; i < n; i++)
            {
                --n;
                await ElementsSelectionConf.SelectBack(arr[i] as Rectangle, arr[n] as Rectangle);

                double tmp = (arr[i] as Rectangle).Height;
                (arr[i] as Rectangle).Height = (arr[n] as Rectangle).Height;
                (arr[n] as Rectangle).Height = tmp;
            }
        }
    }
}
