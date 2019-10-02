#if NET35
using System;

namespace RockLib.Immutable
{
    /// <summary>
    /// Provides support for lazy initialization.
    /// </summary>
    /// <typeparam name="T">The type of object that is being lazily initialized.</typeparam>
    public class Lazy<T>
    {
        private readonly object _locker = new object();
        private Func<T> _valueFactory;
        private volatile bool _isValueCreated;
        private T _value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Lazy{T}" /> class. When lazy initialization
        /// occurs, the specified initialization function is used.
        /// </summary>
        /// <param name="valueFactory">The delegate that is invoked to produce the lazily initialized value when it is needed.</param>
        public Lazy(Func<T> valueFactory) => _valueFactory = valueFactory ?? throw new ArgumentNullException(nameof(valueFactory));

        /// <summary>
        /// Gets a value that indicates whether a value has been created for this <see cref="Lazy{T}" /> instance.
        /// </summary>
        public bool IsValueCreated => _isValueCreated;

        /// <summary>
        /// Gets the lazily initialized value of the current <see cref="Lazy{T}" /> instance.
        /// </summary>
        public T Value
        {
            get
            {
                if (!_isValueCreated)
                    lock (_locker)
                        if (!_isValueCreated)
                        {
                            _value = _valueFactory.Invoke();
                            _valueFactory = null;
                            _isValueCreated = true;
                        }

                return _value;
            }
        }
    }
}
#endif
