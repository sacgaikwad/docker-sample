First()
It returns the first element of a sequence.
It throws an error when there is no element in the result, or source is null.
We should use it if more than one element is expected and you want only the first element.

FirstOrDefault()
It returns the first element of a sequence, or a default value if no element is found.
It throws an error only if the source is null.
We should use it if more than one element is expected and you want only the first element. It's also good if the result is empty.

Single()
It returns the only item of a sequence.
This will throw an exception if the result contains 0 or more than 1 elements.
We should use it, when we know that exactly one element is expected but neither 0 nor 2 or more.

SingleOrDefault()
It returns single specific element, and if the element is not found, it returns the default value of it.
This will throw an exception if the result contains 2 or more elements.
We should use it when we know that 0 or 1 element is expected as result.


If your result set returns 0 records:

SingleOrDefault returns the default value for the type (e.g. default for int is 0)
FirstOrDefault returns the default value for the type
If you result set returns 1 record:

SingleOrDefault returns that record
FirstOrDefault returns that record
If your result set returns many records:

SingleOrDefault throws an exception
FirstOrDefault returns the first record
Conclusion:

If you want an exception to be thrown if the result set contains many records, use SingleOrDefault.

If you always want 1 record no matter what the result set contains, use FirstOrDefault