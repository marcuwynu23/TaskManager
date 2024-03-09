using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Migrations
{
    /// <inheritdoc />
    public partial class DummyTaskData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Title", "Description", "IsComplete" },
                values: new object[]
                {
                    "Organize Team Meeting",
                    "Schedule and conduct a team meeting to discuss project updates and address any issues or concerns.",
                    false
                }
            );

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Title", "Description", "IsComplete" },
                values: new object[]
                {
                    "Research Market Trends",
                    "Gather data on market trends and competitor activities to inform strategic decision-making.",
                    false
                }
            );

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Title", "Description", "IsComplete" },
                values: new object[]
                {
                    "Implement Security Updates",
                    "Install and configure security updates for software and systems to protect against vulnerabilities.",
                    false
                }
            );

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Title", "Description", "IsComplete" },
                values: new object[]
                {
                    "Develop Product Roadmap",
                    "Collaborate with product management to create a roadmap outlining upcoming features and enhancements.",
                    false
                }
            );

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Title", "Description", "IsComplete" },
                values: new object[]
                {
                    "Create Social Media Content Calendar",
                    "Plan and schedule social media posts to maintain an active online presence and engage with followers.",
                    false
                }
            );

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Title", "Description", "IsComplete" },
                values: new object[]
                {
                    "Deploy Application Updates",
                    "Roll out new features and bug fixes to the production environment following established deployment procedures.",
                    false
                }
            );

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Title", "Description", "IsComplete" },
                values: new object[]
                {
                    "Train New Team Members",
                    "Provide training and mentorship to onboard new team members and ensure they are equipped for their roles.",
                    false
                }
            );

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Title", "Description", "IsComplete" },
                values: new object[]
                {
                    "Conduct User Experience Testing",
                    "Recruit participants to test the usability of a software application and gather feedback for improvements.",
                    false
                }
            );

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Title", "Description", "IsComplete" },
                values: new object[]
                {
                    "Update Employee Handbook",
                    "Review and revise the employee handbook to reflect changes in company policies and procedures.",
                    false
                }
            );

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Title", "Description", "IsComplete" },
                values: new object[]
                {
                    "Monitor Server Performance",
                    "Monitor server metrics and respond to alerts to ensure optimal performance and uptime.",
                    false
                }
            );

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Title", "Description", "IsComplete" },
                values: new object[]
                {
                    "Coordinate Product Launch Event",
                    "Plan and execute a launch event for a new product, including venue selection and marketing collateral.",
                    false
                }
            );

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Title", "Description", "IsComplete" },
                values: new object[]
                {
                    "Review Contracts",
                    "Review legal contracts and agreements to ensure compliance and mitigate potential risks.",
                    false
                }
            );

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Title", "Description", "IsComplete" },
                values: new object[]
                {
                    "Conduct Employee Satisfaction Survey",
                    "Design and administer a survey to gauge employee satisfaction and identify areas for improvement.",
                    false
                }
            );

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Title", "Description", "IsComplete" },
                values: new object[]
                {
                    "Optimize Supply Chain Logistics",
                    "Analyze supply chain operations and identify opportunities to streamline processes and reduce costs.",
                    false
                }
            );

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Title", "Description", "IsComplete" },
                values: new object[]
                {
                    "Prepare Quarterly Financial Reports",
                    "Compile financial data and prepare reports for stakeholders to review the company's financial performance.",
                    false
                }
            );

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Title", "Description", "IsComplete" },
                values: new object[]
                {
                    "Coordinate Employee Training Sessions",
                    "Schedule training sessions on topics such as diversity awareness, conflict resolution, and time management.",
                    false
                }
            );

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Title", "Description", "IsComplete" },
                values: new object[]
                {
                    "Implement Energy Conservation Measures",
                    "Identify and implement strategies to reduce energy consumption and promote sustainability within the organization.",
                    false
                }
            );

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Title", "Description", "IsComplete" },
                values: new object[]
                {
                    "Analyze Customer Feedback",
                    "Review feedback from customers and implement improvements to products or services based on their suggestions.",
                    false
                }
            );

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Title", "Description", "IsComplete" },
                values: new object[]
                {
                    "Coordinate Team Building Workshop",
                    "Organize a workshop to enhance team communication and collaboration skills.",
                    false
                }
            );

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Title", "Description", "IsComplete" },
                values: new object[]
                {
                    "Develop Content Marketing Strategy",
                    "Create a plan for content creation and distribution to attract and engage target audiences.",
                    false
                }
            );

            // Insert more tasks as needed...
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Tasks");
        }
    }
}
