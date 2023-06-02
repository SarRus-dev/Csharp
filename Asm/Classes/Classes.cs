namespace Classes{
    public class Classes{
        public string? ClassName { get; set; }
        public string? Studyday { get; set; }
        public string? StudyTime { get; set; }
        public string?  ClassRoom { get; set; }
        public string? Status { get; set; }
        public string? Faculty { get; set; }
        // public Classes() { }
        public static Classes AddCls(){
            Classes ThemClass = new Classes();
            Console.WriteLine("==================================================\n");
            Console.WriteLine(" NEW CLASSES\n");
            Console.WriteLine("==================================================\n");
            Console.Write("Class Name: ");
            ThemClass.ClassName = Console.ReadLine();
            Console.Write("Stuyday: ");
            ThemClass.Studyday = Console.ReadLine();
            Console.Write("Study Time: ");
            ThemClass.StudyTime = Console.ReadLine();
            Console.Write("Class Room: ");
            ThemClass.ClassRoom = Console.ReadLine();
            Console.Write("Status (Studying, Pause, Finish, Closed): ");
            ThemClass.Status = Console.ReadLine();
            Console.Write(" Faculty: ");
            ThemClass.Faculty = Console.ReadLine();
            return ThemClass;
        }
        public static void saveCls(List<Classes> list){
            do
            {
                list.Add(Classes.AddCls());
                Console.WriteLine("==================================================\n");
                Console.WriteLine("Add CLASS Comlete! \n");
                Console.WriteLine("Do you want to continue? (Y/N): ");
                string st = Console.ReadLine() ?? "";
                if (st.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            } while (true);
        }
    }
}