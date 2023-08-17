using CSharpExercisesFirstTry.Exercise;
using CSharpExercisesFirstTry.TUI;

namespace program
{
    class program
    {
        public static void Main(string[] args)
        {
            // Main Program running 
            Console.WriteLine("******** Program Execises C# *********" + "\n");
            MainTUI(new CategoryTUI());
        }

        static void MainTUI(CategoryTUI mainTUI)
        {
            mainTUI.TUI();
        }

    }
}









