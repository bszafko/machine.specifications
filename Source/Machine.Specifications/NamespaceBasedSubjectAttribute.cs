using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Machine.Specifications
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class NamespaceBasedSubjectAttribute : SubjectAttribute
    {
        public NamespaceBasedSubjectAttribute(Type subjectType)
        {
            _subject = subjectType.Namespace;
            int idxOfAs = _subject.IndexOf(".As.") + 1;
            _subject = _subject.Substring(idxOfAs);
            _subject = _subject.Replace(".", " ");
            _subject = _subject.Replace("_", " ");
            if (subjectType.Name.StartsWith("when"))
                _subject = _subject.Replace("when", String.Empty);
        }
    }
}
