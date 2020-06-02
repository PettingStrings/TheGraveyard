using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGraveyard.Cls.MyQueries
{
    public static class MyQueries
    {
        public static string EmailExists(string email)
        {
            return $"SELECT Count(email) FROM accounts WHERE(((accounts.[email]) = '{email}')); ";
        }

        public static string InsertAccount(string email, string username, string password, bool isVerified = false)
        {
            return $"INSERT INTO ACCOUNTS VALUES('{email}', '{username}', '{password}', {isVerified}, 0, 0, date(), false); ";
        }

        public static string GetAccount(string email, string password)
        {
            return $"SELECT * FROM accounts WHERE email = '{email}' AND password = '{password}';";
        }

        public static string GetUnlockedLevels(string email)
        {
            return $"SELECT Count(*) FROM punteggi WHERE utente = '{email}';";
        }

        public static string AccountExists(string email, string password)
        {
            return $"SELECT Count(*) FROM ACCOUNTS WHERE(((ACCOUNTS.email) = '{email}') And((ACCOUNTS.password) = '{password}'));";
        }

        public static string UpdatePlayer(string email,string username, string passowrd, bool verificato,int uccisionitotali,
            int mortiTotali,bool ban = false)
        {
            return $@"UPDATE ACCOUNTS SET 
                    email = '{email}',
                    nome = '{username}',
                    [password] = '{passowrd}',
                    verificato = {(verificato ? 1 : 0)},
                    uccisioniTotali = {uccisionitotali},
                    mortiTotali = {mortiTotali},
                    ultimoBackup = DATE(),
                    ban = {(ban ? 1:0)}

                    WHERE email = '{email}';";
        }

        public static string CountScores(string email,int level) 
        {
            return $@"SELECT Count(*) 
                    FROM punteggi
                    WHERE(((punteggi.[utente]) = '{email}') AND ((punteggi.[livello]) = {level}));";
        }

        public static string InsertScore(string email, int level,int kills, int time)
        {
            return $@"INSERT INTO PUNTEGGI 
                    VALUES ({level}, {kills}, {time}, date(), '{email}');
";
        }

        public static string UpdateScore(string email, int level, int kills, int time)
        {
            return $@"UPDATE PUNTEGGI SET uccisioni = {kills}, tempo = {time}, data = date()
                    WHERE utente = '{email}' AND livello = {level};";
        }

    }
}
