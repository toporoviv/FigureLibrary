using System.Runtime.Serialization;

namespace FigureLibrary.Exceptions.TriangleExceptions;
public class InvalidSideException : Exception
{
    public InvalidSideException() : base()
    {
    }

    protected InvalidSideException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }

    public InvalidSideException(string? message) : base(message)
    {
    }

    public InvalidSideException(string? message, Exception? innerException)
        : base(message, innerException)
    {
    }
}
