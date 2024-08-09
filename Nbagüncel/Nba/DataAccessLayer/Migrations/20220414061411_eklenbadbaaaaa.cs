using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class eklenbadbaaaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Weight",
                table: "oyuncular",
                newName: "eFG");

            migrationBuilder.RenameColumn(
                name: "Turnovers",
                table: "oyuncular",
                newName: "TwPP");

            migrationBuilder.RenameColumn(
                name: "TPFieldGoalPercentage",
                table: "oyuncular",
                newName: "TwPA");

            migrationBuilder.RenameColumn(
                name: "Rebounds",
                table: "oyuncular",
                newName: "TwP");

            migrationBuilder.RenameColumn(
                name: "Points",
                table: "oyuncular",
                newName: "TRB");

            migrationBuilder.RenameColumn(
                name: "PlayerSurname",
                table: "oyuncular",
                newName: "Playerimg");

            migrationBuilder.RenameColumn(
                name: "Height",
                table: "oyuncular",
                newName: "TPP");

            migrationBuilder.RenameColumn(
                name: "GamesPlayed",
                table: "oyuncular",
                newName: "GamesStarted");

            migrationBuilder.RenameColumn(
                name: "FreeThrowPercentage",
                table: "oyuncular",
                newName: "TPA");

            migrationBuilder.RenameColumn(
                name: "FieldGoalPercentage",
                table: "oyuncular",
                newName: "TP");

            migrationBuilder.RenameColumn(
                name: "Blocks",
                table: "oyuncular",
                newName: "TOV");

            migrationBuilder.RenameColumn(
                name: "Assists",
                table: "oyuncular",
                newName: "STL");

            migrationBuilder.AddColumn<string>(
                name: "Conference",
                table: "takimlar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Lose",
                table: "takimlar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "OpponentPointsPerGame",
                table: "takimlar",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PointsPerGame",
                table: "takimlar",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Win",
                table: "takimlar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "WinLosePercentage",
                table: "takimlar",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "AST",
                table: "oyuncular",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "BLK",
                table: "oyuncular",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "DRB",
                table: "oyuncular",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "FG",
                table: "oyuncular",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "FGA",
                table: "oyuncular",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "FGP",
                table: "oyuncular",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "FT",
                table: "oyuncular",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "FTA",
                table: "oyuncular",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "FTP",
                table: "oyuncular",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Games",
                table: "oyuncular",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "MP",
                table: "oyuncular",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ORB",
                table: "oyuncular",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PF",
                table: "oyuncular",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PTS",
                table: "oyuncular",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Conference",
                table: "takimlar");

            migrationBuilder.DropColumn(
                name: "Lose",
                table: "takimlar");

            migrationBuilder.DropColumn(
                name: "OpponentPointsPerGame",
                table: "takimlar");

            migrationBuilder.DropColumn(
                name: "PointsPerGame",
                table: "takimlar");

            migrationBuilder.DropColumn(
                name: "Win",
                table: "takimlar");

            migrationBuilder.DropColumn(
                name: "WinLosePercentage",
                table: "takimlar");

            migrationBuilder.DropColumn(
                name: "AST",
                table: "oyuncular");

            migrationBuilder.DropColumn(
                name: "BLK",
                table: "oyuncular");

            migrationBuilder.DropColumn(
                name: "DRB",
                table: "oyuncular");

            migrationBuilder.DropColumn(
                name: "FG",
                table: "oyuncular");

            migrationBuilder.DropColumn(
                name: "FGA",
                table: "oyuncular");

            migrationBuilder.DropColumn(
                name: "FGP",
                table: "oyuncular");

            migrationBuilder.DropColumn(
                name: "FT",
                table: "oyuncular");

            migrationBuilder.DropColumn(
                name: "FTA",
                table: "oyuncular");

            migrationBuilder.DropColumn(
                name: "FTP",
                table: "oyuncular");

            migrationBuilder.DropColumn(
                name: "Games",
                table: "oyuncular");

            migrationBuilder.DropColumn(
                name: "MP",
                table: "oyuncular");

            migrationBuilder.DropColumn(
                name: "ORB",
                table: "oyuncular");

            migrationBuilder.DropColumn(
                name: "PF",
                table: "oyuncular");

            migrationBuilder.DropColumn(
                name: "PTS",
                table: "oyuncular");

            migrationBuilder.RenameColumn(
                name: "eFG",
                table: "oyuncular",
                newName: "Weight");

            migrationBuilder.RenameColumn(
                name: "TwPP",
                table: "oyuncular",
                newName: "Turnovers");

            migrationBuilder.RenameColumn(
                name: "TwPA",
                table: "oyuncular",
                newName: "TPFieldGoalPercentage");

            migrationBuilder.RenameColumn(
                name: "TwP",
                table: "oyuncular",
                newName: "Rebounds");

            migrationBuilder.RenameColumn(
                name: "TRB",
                table: "oyuncular",
                newName: "Points");

            migrationBuilder.RenameColumn(
                name: "TPP",
                table: "oyuncular",
                newName: "Height");

            migrationBuilder.RenameColumn(
                name: "TPA",
                table: "oyuncular",
                newName: "FreeThrowPercentage");

            migrationBuilder.RenameColumn(
                name: "TP",
                table: "oyuncular",
                newName: "FieldGoalPercentage");

            migrationBuilder.RenameColumn(
                name: "TOV",
                table: "oyuncular",
                newName: "Blocks");

            migrationBuilder.RenameColumn(
                name: "STL",
                table: "oyuncular",
                newName: "Assists");

            migrationBuilder.RenameColumn(
                name: "Playerimg",
                table: "oyuncular",
                newName: "PlayerSurname");

            migrationBuilder.RenameColumn(
                name: "GamesStarted",
                table: "oyuncular",
                newName: "GamesPlayed");
        }
    }
}
