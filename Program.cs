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
        Console.WriteLine($"Sum: {sum}, GPA: {gpa}");
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

/* Lab 07 - 08 (Lab 07 từ câu 01-05, Lab 08 từ câu 06-07).
    Một lớp Point trong hệ toạ độ Descartes 2 chiều gồm các
    thuộc tính: x, y. Một lớp Cluster chứa một list các Point.
    1/ Xây dựng lớp Point.
    2/ Bổ sung vào Point: ToString dạng A(x, y), distance
     - tính khoảng cách giữa 2 điểm theo Euclidean.
    3/ Bổ sung vào lớp Cluster: ToString dạng {A(x, y), B(x, y), C(x, y)}
    4/ Bổ sung phương thức distance cho Cluster để tính
    khoảng cách giữa các cụm theo single linkage (theo
    khoảng cách nhỏ nhất giữa các cặp điểm của 2 cụm).
    5/ Bổ sung operator + để hợp 2 Cluster.
    6/ Cài đặt thuật toán hierarchical clustering để phân
     cụm (với single linkage).
        - public List<Cluster> HierarchicalClustering()
    7/ Triển khai kết quả trong hàm main.
*/