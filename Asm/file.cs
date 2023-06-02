using System.IO;
using System.Text.Json;
public class filewokss
{
    public static void Asm(List<HocVien.HocVien> hv, List<Classes.Classes> cls, string filestudent, string fileclass){
        List <string> students = new List<string>();
        string json;
        foreach(HocVien.HocVien item in hv){
            json = JsonSerializer.Serialize(item);
            students.Add(json);
        }
        File.WriteAllLines(filestudent, students);

        List <string> classes = new List<string>();
        foreach(Classes.Classes item in cls){
            json = JsonSerializer.Serialize(item);
            classes.Add(json);
        }
        File.WriteAllLines(fileclass, classes);
    }
    // public static List<HocVien.HocVien> load(List<HocVien.HocVien> hv,string filestudent){
    //     List <HocVien.HocVien> returnHv = new List<HocVien.HocVien>();
    //     var lines=File.ReadAllLines(filestudent).ToList();
    //     foreach(string item in lines){
    //          HocVien.HocVien ?student=JsonSerializer.Deserialize<HocVien.HocVien>(item);
    //          returnHv.Add(student);
    //     }
    //     return returnHv;
    // }
}