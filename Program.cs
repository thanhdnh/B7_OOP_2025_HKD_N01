public class Course
{
    private string id;
    private string title;
    private double weight;
    private double point;
    public Course(string id, string title, double weight, double point)
    {
        this.id = id;
        this.title = title;
        this.weight = weight;
        this.point = point;
    }

    public double Point { get => point; }

    public override string ToString()
    {
        return $"{title}<{Point}, {weight}>";
    }
    public static Course operator +(Course a, Course b)
    {
        return new Course("", "", 1,
            a.Point * a.weight + b.Point * b.weight);
    }
    /*public static double operator +(Course a, Course b){
        return a.point*a.weight + b.point*b.weight;
    }*/
    public static Course operator /(Course a, Course b){
        return new Course("", "", a.weight + b.weight, 
            (a.Point * a.weight + 
                b.Point * b.weight) / (a.weight + b.weight));
    }
}
public class Program{
    public static void Main(string[] args){
        Console.Clear();
        Course toan = new Course("SE01", "Toan", 2, 8);
        Course ly = new Course("SE02", "Ly", 1, 7);
        Course hoa = new Course("SE03", "Hoa", 1, 9);
        double sum = (toan + ly + hoa).Point;
        double gpa = (toan/ly/hoa).Point;//(2*8+1*7+1*9)/4
    }
}
/*
    Một lớp môn học gồm có các thuộc tính sau: mã môn, 
    tên môn, trọng số, điểm số.
    1/ Xây dựng lớp môn học với các thuộc tính trên.
    2/ Quá tải ToString dưới dạng: Tên môn<điểm, trọng số>.
    3/ Xd operator + để cộng điểm của 2 môn theo trọng số.
    4/ Xd operator / để tính điểm trung bình của 2 môn theo trọng số.
    5/ Xd hàm main với đầu vào là một danh sách các môn học
    mà một Sinh viên nào đó đã học và test thử các methods.
*/