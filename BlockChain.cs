using System;
using System.Collections.Generic;
using System.Diagnostics;

/// <summary>
/// Summary description for Class1
/// </summary>
public class BlockChain
{
	public IList<Block> Chain { set; get; }
	public int Difficulty { get; set; } = 4;
	//List<Transaction> PendingTransactions = new List<Transaction>();
	List<Emissions> PendingTransactions = new List<Emissions>();
	//List<Emissions> PendingEmissions = new List<Emissions>();

	public BlockChain(bool load)
	{
		InitializeChain();
        if (!load)
        {
			AddGenesisBlock();
		}
	
	}

	public void InitializeChain()
	{
		Chain = new List<Block>();
	}

	//GenesisBlock is always empty of data
	public Block CreateGenesisBlock()
	{
		Block block = new Block(DateTime.Now, null, new List<Emissions>());
		IO io = new IO();
		io.Save(block);

		//return new Block(DateTime.Now, null, new List<Transaction>());
		return block;
	}

	public void AddGenesisBlock()
	{
		Chain.Add(CreateGenesisBlock());
	}
	public Block GetLatestBlock()
	{
		return Chain[Chain.Count - 1];
	}
	public void AddBlock(Block block)
	{
		Block latestBlock = GetLatestBlock();
		block.Index = latestBlock.Index + 1;
		block.PreviousHash = latestBlock.Hash;
		Stopwatch timer = new Stopwatch();
		timer.Start();
		block.Mine(this.Difficulty);
		timer.Stop();
		string elapsedTime = timer.ElapsedMilliseconds.ToString();
		Chain.Add(block);
	}

	public bool IsValid()
	{
		for (int i = 1; i < Chain.Count; i++)
		{
			Block currentBlock = Chain[i];
			Block previousBlock = Chain[i - 1];

			if (currentBlock.Hash != currentBlock.CalculateHash())
			{
				return false;
			}

			if (currentBlock.PreviousHash != previousBlock.Hash)
			{
				return false;
			}
		}
		return true;
	}



	/// <summary>
	/// Function to check that the blockchain has not been compromised
	/// </summary>
	/// <returns>If the blockchain is valid returns 0
	/// Else return the Index of the Compromised Block
	/// </returns>
	public int IsValidInt() {
		for (int i = 1; i < Chain.Count; i++)
		{
			Block currentBlock = Chain[i];
			Block previousBlock = Chain[i - 1];

			if (currentBlock.Hash != currentBlock.CalculateHash())
			{
				return i;
			}

			if (currentBlock.PreviousHash != previousBlock.Hash)
			{
				return i-1;
			}
		}
		return 0;
	}

	public List<int> IsValidList() {

		List<int> validList = new List<int>();
		for (int i = 1; i < Chain.Count; i++)
		{
			Block currentBlock = Chain[i];
			Block previousBlock = Chain[i - 1];

			if (currentBlock.Hash != currentBlock.CalculateHash())
			{
				validList.Add(i);
			}

			if (currentBlock.PreviousHash != previousBlock.Hash)
			{
				validList.Add(i-1);
			}
		}

		return validList;
	}

	/*
	public void CreateTransaction(Transaction transaction) {
		PendingTransactions.Add(transaction);
	}
	*/
	public void CreateTransaction(Emissions emissions)
	{
		PendingTransactions.Add(emissions);
	}

	public void LoadTransaction(Emissions emissions)
	{
	
	}

	public void ProcessPendingTransactions(string minerAdress)
    {
		IO myIo = new IO();
		Block block = new Block(DateTime.Now, GetLatestBlock().Hash, PendingTransactions);
		AddBlock(block);
		myIo.Save(block);
		PendingTransactions = new List<Emissions>();
		//CreateTransaction(new Transaction(null, minerAdress, Reward)); //This will be used in case we want to reward
													     //the miner for helping generating a new block
	}

	public void LoadPendingTransactions(int index, DateTime timeStamp, string previousHash, string hash, int nonce, string minerAdress)
	{
		Block blk = new Block(index, timeStamp, previousHash, PendingTransactions, hash, nonce);
		//Block block = new Block(DateTime.Now, GetLatestBlock().Hash, PendingTransactions);
		Chain.Add(blk);
       
		//PendingTransactions = new List<Transaction>();
		PendingTransactions = new List<Emissions>();
		//CreateTransaction(new Transaction(null, minerAdress, Reward)); //This will be used in case we want to reward the miner for helping generating a new block
	}
}
