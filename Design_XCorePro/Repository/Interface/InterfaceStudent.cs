using Design_XCorePro.Model;

namespace Design_XCorePro.Repository.Interface
{
    public interface InterfaceStudent
    {
        Task<List<Student>> GetStdList();

        Task<Student> AddStudent(Student student);

        Task<Student> DeleteStudent(int Id);

        Task<Student> UpdateStudent(Student student);
    }
}
