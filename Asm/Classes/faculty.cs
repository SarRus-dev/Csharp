namespace Classes
{
    public class FacultyCls
    {
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }

        public string Faculty
        {
            get
            {
                return $"{FirstName} {MiddleName} {LastName}".Trim();
            }
        }
        public static FacultyCls AddFaculty()
        {
            FacultyCls Faculty = new FacultyCls();
            Console.WriteLine(" <Faculty>");
            Console.Write("FirstName: ");
            Faculty.FirstName = Console.ReadLine();
            Console.Write("MiddleName: ");
            Faculty.MiddleName = Console.ReadLine();
            Console.Write("LastName: ");
            Faculty.LastName = Console.ReadLine();
            Console.Write("Phone: ");
            Faculty.Phone = Console.ReadLine();
            Console.Write("Email: ");
            Faculty.Email = Console.ReadLine();
            return Faculty;
        }
        public static void saveGv(List<FacultyCls> list)
        {
                list.Add(FacultyCls.AddFaculty());
        }
    }
}