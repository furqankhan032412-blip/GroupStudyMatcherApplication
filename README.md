# GroupStudyMatcherApplication

## Overview
GroupStudyMatcherApplication is a Windows Forms application built with C# that helps students find and form study groups. The application provides user authentication, group creation, search functionality, and matching capabilities to connect students with similar study interests and schedules.

## Features
- **User Authentication**: Login and registration system for students
- **Dashboard**: Central hub for accessing all application features
- **Group Creation**: Create new study groups with specific subjects, schedules, and requirements
- **Group Search**: Find existing study groups based on criteria
- **Smart Matching**: Algorithm to match students with compatible study partners
- **Admin Dashboard**: Administrative interface for managing users and groups
- **Profile Management**: View and update user profiles
- **Group Details**: View detailed information about specific study groups
- **User Data Management**: Persistent storage of user information and group data

## Technologies Used
- **Language**: C#
- **Framework**: .NET Framework (Windows Forms)
- **Architecture**: Windows Forms Desktop Application
- **Data Storage**: Local file-based storage (UserData.cs)

## Project Structure
```
GroupStudyMatcherApplication/
├── Properties/          # Project properties and settings
├── Resources/          # Application resources (images, icons, etc.)
├── bin/               # Compiled binaries
├── obj/               # Object files
├── Forms/
│   ├── Login.cs           # Login interface
│   ├── Register.cs        # Registration interface
│   ├── Dashboard.cs       # Main dashboard
│   ├── AdminDashboardForm.cs  # Admin interface
│   ├── CreateGroup.cs     # Group creation interface
│   ├── SearchSystem.cs    # Search functionality
│   ├── Match.cs           # Matching algorithm
│   ├── findstudymatch.cs  # Find study match
│   ├── DetailsForm.cs     # Group details view
│   ├── VIEWGROUPSFORM.cs  # View all groups
│   ├── profile.cs         # User profile management
│   └── Form1.cs.txt       # Legacy form (disabled)
├── Program.cs         # Application entry point
├── UserData.cs        # Data management class
├── StudyMatcher.csproj # Project file
├── packages.config    # NuGet package dependencies
├── App.config         # Application configuration
└── .gitattributes     # Git configuration
```

## Installation

### Prerequisites
- Windows Operating System
- .NET Framework (version specified in project properties)
- Visual Studio (recommended) or any C# compatible IDE

### Steps
1. Clone the repository:
```bash
git clone https://github.com/furqankhan032412-blip/GroupStudyMatcherApplication.git
```

2. Open the solution in Visual Studio:
```bash
cd GroupStudyMatcherApplication
start StudyMatcher.sln
```

3. Restore NuGet packages:
```
Right-click on solution -> Restore NuGet Packages
```

4. Build the solution:
```
Build -> Build Solution (Ctrl+Shift+B)
```

5. Run the application:
```
Debug -> Start Debugging (F5)
```

## Usage Guide

### Getting Started
1. **Register** a new account using the registration form
2. **Login** with your credentials
3. Access the **Dashboard** to explore available features

### Creating a Study Group
1. Navigate to "Create Group" from the dashboard
2. Fill in group details:
   - Group name
   - Subject/Course
   - Schedule and timings
   - Maximum members
   - Any prerequisites
3. Submit to create the group

### Finding Study Partners
1. Use the **Search System** to find existing groups
2. Filter by subject, schedule, or preferences
3. Use the **Find Study Match** feature for intelligent matching
4. View group details using **DetailsForm**

### Admin Features
- Access Admin Dashboard for user and group management
- Monitor user activity and groups
- Administrative controls for system maintenance

### Profile Management
- Update your profile information
- View your study preferences
- Check your current groups and pending requests

## Data Storage
User data and group information are managed through `UserData.cs` class, which handles local storage operations. The application currently uses file-based storage for simplicity.

## Future Enhancements
- Database integration for better data persistence
- Real-time notification system
- Calendar integration for schedule management
- Mobile application support
- Advanced matching algorithms
- Chat functionality within study groups

## Contributing
1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License
This project is currently unlicensed. Please contact the repository owner for usage rights.

## Author

Furqan Khan
Artificial Intelligence Student

## Contact
**Furqan Khan** - [GitHub Profile](https://github.com/furqankhan032412-blip)

Project Link: [https://github.com/furqankhan032412-blip/GroupStudyMatcherApplication](https://github.com/furqankhan032412-blip/GroupStudyMatcherApplication)

## Acknowledgments
- Thanks to all contributors and users of this application
- Built with .NET Framework and Windows Forms
- Special thanks to the testing team for feedback
