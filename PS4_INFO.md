## Server
- Establishing Connection:
  - The client (PC) connects to the PS4 server over a local network, establishing a communication channel.
- Sending Requests:
  - The client can send various requests to the server, such as initiating memory scans, reading specific memory addresses, or modifying memory values.
- Processing Requests:
  - Upon receiving a request, the server processes it by performing the necessary operations on the PS4's memory or processes. This may involve executing a local scan or applying changes to the memory.
- Returning Results:
  - After processing the request, the server sends the results back to the client. For example, it might return the results of a memory scan or confirm that a memory modification was successful.
- Real-Time Interaction:
  - This connection allows for real-time interaction, enabling users to see immediate feedback and make iterative changes as needed.


## PS4 Operating System and Kernel
The PS4 console operates on a custom Operating system known as Orbis OS, which is based on a modified version of FreeBSD (an open-source Unix-like operating system). 
The Orbis OS utilizes a specialized kernel optimized for gaming, built around the x86-64 architecture to support the AMD Accelerated Processing Unit (APU) that powers the console. 

## Process Management on the PS4
Orbis OS manages processes within a structured and efficient multitasking environment. Key features include:
- Isolated Memory Spaces: Each process runs in its own memory space, ensuring secure memory allocation and access.
- Memory Segmentation: The process memory is organized into several segments:
  - Text Segment: Contains executable code.
  - Data Segment: Holds global variables.
  - Heap and Stack Segments: Used for dynamic memory allocation and function calls.
- Process Scheduling: The operating system employs a scheduler that allocates CPU time to each running process, facilitating smooth performance during gaming and application execution.
- Inter-Process Communication (IPC): Processes can communicate and synchronize their operations through IPC mechanisms, allowing for data sharing.
