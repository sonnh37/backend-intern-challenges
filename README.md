## Short Explanation


### Approach

The promotion code is validated by checking whether it exists in both data sources.

Each file is processed line by line using streaming.

A promotion code is considered eligible only if it appears in both files.


### Data Structures Used

No in-memory data structures are used.

The implementation relies on file streaming (`File.ReadLines`) to avoid loading large files into memory.


### Performance Considerations

- Time complexity: *O(n)* in the worst case.

- Early exit is applied as soon as the code is found.

- Memory usage is constant: *O(1)*

- The solution is *I/O-bound* and optimized for low memory consumption.



### Assumptions

- Input files can be very large and may not fit entirely into memory.

- Promotion codes inside the files are valid and unique, as guaranteed by the problem statement.

- Only one promotion code is validated per request.

