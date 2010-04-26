using System;

namespace Machine.Specifications
{
  [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
  public class SubjectAttribute : Attribute
  {
    readonly Type _subjectType;
    protected string _subject;

    public Type SubjectType
    {
      get { return _subjectType; }
    }

    public string SubjectText
    {
      get { return _subject; }
    }

    public SubjectAttribute() { }

    public SubjectAttribute(Type subjectType)
    {
      this._subjectType = subjectType;
    }

    public SubjectAttribute(Type subjectType, string subject)
    {
      _subjectType = subjectType;
      _subject = subject;
    }

    public SubjectAttribute(string subject)
    {
      _subject = subject;
    }
  }
}
