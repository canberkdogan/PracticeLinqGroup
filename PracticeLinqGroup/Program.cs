using PracticeLinqGroup;

var studentList = new List<Student>();
studentList.Add(new Student { StudentId = 1, StudentName = "Ali", ClassId = 1 });
studentList.Add(new Student { StudentId = 2, StudentName = "Ayşe", ClassId = 2 });
studentList.Add(new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 1 });
studentList.Add(new Student { StudentId = 4, StudentName = "Fatma", ClassId = 3 });
studentList.Add(new Student { StudentId = 5, StudentName = "Ahmet", ClassId = 2 });


var classList = new List<Class>();

classList.Add(new Class { ClassId = 1, ClassName = "Matematik" });
classList.Add(new Class { ClassId = 2, ClassName = "Türkçe" });
classList.Add(new Class { ClassId = 3, ClassName = "Kimya" });


var studentAndClass = classList.GroupJoin(
    studentList,
    classes => classes.ClassId,
    student => student.ClassId,
    (classes, studentGroup) => new
    {
        ClassName = classes.ClassName,
        Student = studentGroup
    } 
 ); 

foreach ( var classes in studentAndClass)
{
    Console.WriteLine($"↓ {classes.ClassName} Dersi Alan Öğrenciler ↓");
    foreach ( var student in classes.Student)
    {
        Console.WriteLine($"{student.StudentName}");
    }
}


