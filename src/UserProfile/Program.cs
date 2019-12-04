using System;

namespace UserProfile {
    class Program {

        static void A() {
            var a = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            Console.WriteLine(a);
        }

        static void B() {
            var a = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Console.WriteLine(a);
        }

        static void Main(string[] args) {
            A();
            B();

            var h = Environment.ExpandEnvironmentVariables("%ANDROID_HOME%");
            Console.WriteLine(h);
        }
    }
}