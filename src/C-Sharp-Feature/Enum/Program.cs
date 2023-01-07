using Enum;
AccountStatus GetStatus()
{
    return AccountStatus.Blocked;
}

AccountStatus accountstatus = GetStatus();


if ( accountstatus == AccountStatus.Active)
{
    Console.WriteLine(accountstatus);
}
else if (accountstatus == AccountStatus.Canceled)
{
    Console.WriteLine((int)accountstatus);
}
else
{
    Console.WriteLine("Not match any case.");
}


