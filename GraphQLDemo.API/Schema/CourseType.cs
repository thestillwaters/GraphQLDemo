namespace GraphQLDemo.API.Schema
{
    public enum Subject
    {
        Math,
        Science,
        History
    }
    public class CourseType
    {
        public Guid Id { get; set; }

        public Subject Subject { get; set; }

        [GraphQLNonNullType]
        public InstructorType? Instructor { get; set; }  
        
        public IEnumerable<StudentType>? Students { get; set; } 

        public string Description()
        {
            return $"{Id}: this is id";
        }
    }
}
