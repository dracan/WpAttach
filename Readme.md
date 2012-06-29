WpAttach - Visual Studio Addin to attach to IIS worker processes
================================================================

A Visual Studio 2010 addon which shows a form with a listbox displaying the currently active IIS W3WP processes. Double clicking (or using the enter key) on a process will attach the current instance of Visual Studio to that process for debugging. The listbox displays the process owner name rather than the process name, which in the case of the w3wp processes, is the name of the application pool. This makes it much easier to differentiate between multiple running w3wp processes.

The plugin will also automatically select the last process you attached to. This makes it even quicker to attach to your required w3wp instance.

Future version of WpAttach will aid with attaching to remote processes.

