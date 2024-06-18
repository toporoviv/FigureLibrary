using System.Runtime.Serialization;

namespace FigureLibrary.Exceptions.CircleExceptions;
public class InvalidRadiusException : Exception
{
    public InvalidRadiusException() : base()
    {
    }

    protected InvalidRadiusException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }

    public InvalidRadiusException(string? message) : base(message)
    {
    }

    public InvalidRadiusException(string? message, Exception? innerException)
        : base(message, innerException)
    {
    }
}
