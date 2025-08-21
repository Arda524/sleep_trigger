# Sleep Trigger

A simple C# console application that provides quick system power management commands through an interactive command-line interface.

## Features

- **Sleep Mode**: Put your computer into suspend/sleep mode
- **Shutdown**: Safely shutdown your computer
- **Restart**: Restart your computer
- **Clear Console**: Clear the terminal screen
- **Interactive Interface**: User-friendly command prompt with colorful ASCII art

## Commands

| Command | Description |
|---------|-------------|
| `sleep` | Put the computer into sleep/suspend mode |
| `off` | Shutdown the computer |
| `reboot` | Restart the computer |
| `clear` | Clear the console screen |
| `quit` | Exit the application |

## Requirements

- Windows operating system
- .NET Framework (compatible with the project's target framework)
- Administrator privileges may be required for some power management operations

## Installation

1. Clone this repository:
   ```bash
   git clone <repository-url>
   cd sleep_trigger
   ```

2. Open the solution in Visual Studio:
   ```bash
   start sleep_trigger.sln
   ```

3. Build the solution (Ctrl+Shift+B in Visual Studio)

## Usage

1. Run the compiled executable or start the application from Visual Studio
2. You'll see the ASCII art banner and available commands
3. Type any of the supported commands at the prompt:
   - Type `sleep` to put your computer to sleep
   - Type `off` to shutdown your computer
   - Type `reboot` to restart your computer
   - Type `clear` to clear the console
   - Type `quit` to exit the application

## Example

```
                   _                             __  __                      _       
     /\           | |                           |  \/  |     /\             (_)      
    /  \   _ __ __| | __ ___      ____ _ _ __   | \  / |    /  \   _ __ ___  _ _ __  
   / /\ \ | '__/ _` |/ _` \ \ /\ / / _` | '_ \  | |\/| |   / /\ \ | '_ ` _ \| | '_ \ 
  / ____ \| | | (_| | (_| |\ V  V / (_| | | | | | |  | |  / ____ \| | | | | | | | | |
 /_/    \_\_|  \__,_|\__,_| \_/\_/ \__,_|_| |_| |_|  |_| /_/    \_\_| |_| |_|_|_| |_|

--------------------------------------------------------
🔹 Available Commands:
 sleep → Suspend (Sleep Mode)
 off   → Shutdown
 reboot→ Restart
 clear → Clear console
 quit  → Exit
--------------------------------------------------------

Say Magic Word> sleep
Putting the laptop to sleep...
```

## Technical Details

The application uses Windows API calls through P/Invoke:
- `SetSuspendState` from `powrprof.dll` for sleep functionality
- `Process.Start` with `shutdown` command for shutdown and restart operations

## Security Note

This application requires system-level permissions to perform power management operations. Always ensure you save your work before using shutdown or restart commands.

## Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Submit a pull request

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Author

Created by Ardawan M Amin