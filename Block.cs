using System;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
/// <summary>
/// Summary description for Class1
/// </summary>
public class Block
{
	public int Index { get; set; }
	public DateTime TimeStamp { get; set; }
	public string PreviousHash { get; set; }
	public string Hash { get; set; }
	//public string Data { get; set; }
	public int Nonce { get; set; } = 0;

	//public IList<Transaction> Transactions { set; get; }
	public IList<Emissions> Transactions { set; get; }


	public Block(DateTime timeStamp, string previousHash, List<Emissions> transaction)
	{
		Index = 0;
		TimeStamp = timeStamp;
		PreviousHash = previousHash;
		Transactions = transaction;
		Hash = CalculateHash();
	}

	public Block(int index, DateTime timeStamp, string previousHash, List<Emissions> transaction, string hash, int nonce)
	{
		Index = index;
		TimeStamp = timeStamp;
		PreviousHash = previousHash;
		Transactions = transaction;
		Hash = hash;
		Nonce = nonce;
	}

	public string CalculateHash()
	{
		SHA256 sha256 = SHA256.Create();

		byte[] inputBytes = Encoding.ASCII.GetBytes($"{TimeStamp}-{PreviousHash ?? ""}-{JsonConvert.SerializeObject(Transactions)}-{Nonce}"); ;
		byte[] outputBytes = sha256.ComputeHash(inputBytes);

		return Convert.ToBase64String(outputBytes);
	}
	/// <summary>
	/// This function sets the criteria of a valid hash and then utilizes computer power in order to design a valid hash for a new block
	/// </summary>
	/// <param name="difficulty"></param>
	public void Mine(int difficulty)
	{
		var leadingZeros = new string('0', difficulty);
		while (this.Hash == null || this.Hash.Substring(0, difficulty) != leadingZeros)
		{
			this.Nonce++;
			this.Hash = this.CalculateHash();
		}
	}


}
