using System;
namespace Module5
{
    public class Opgave5_1
    {
        public static void Run() {
            var a = new List<int>(new int[] { 1, 2, 3, 4, 6 });
            Console.WriteLine(IsUnique2(a));

            a = new List<int>(new int[] { 1, 2, 3, 4, 6, 2, 4 });
            Console.WriteLine(IsUnique2(a));

        }

        private static bool IsUnique(List<int> aList) {

            foreach (var v in aList)
                if (aList.Count(x => x == v) > 1)
                    return false;
            return true;
        }

        private static bool IsUnique2(List<int> aList)
        {

            if (aList.Distinct().Count() == aList.Count())
                return true;
            return false;
        }
    }
}

