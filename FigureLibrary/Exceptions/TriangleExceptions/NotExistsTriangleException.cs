using System.Runtime.Serialization;

namespace FigureLibrary.Exceptions.TriangleExceptions;
public class NotExistsTriangleException : Exception
{
    public NotExistsTriangleException() : base()
    {
    }

    protected NotExistsTriangleException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }

    public NotExistsTriangleException(string? message) : base(message)
    {
    }

    public NotExistsTriangleException(string? message, Exception? innerException)
        : base(message, innerException)
    {
    }
}
