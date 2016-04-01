# BitPoker

## Abstract
Inspired by OpenBazaar.com, the goal of the project is to design a peer to peer protocol of games, such as online poker, in which no central actor can control the outcome and thus rig the game and is proovably fair.  The game uses bitcoin and lightning network to settle bets between actors.

Different clients developed in different programming languages are encouraged.

### Notation
| Key  | Value |
| ------------- | ------------- |
| A  | Ace  |
| K  | King  |
| Q  | Queen |
| J  | Jack  |
| T  | Ten |
| 9 | 9 |
| 8 | 8 |
| 7 | 7 |
| 6 | 6 |
| 5 | 5 |
| 4 | 4 |
| 3 | 3 |
| 2 | 2 |

Suites

| Key  | Value |
| ------------- | ------------- |
| S  | Spade  |
| C  | Club |
| H  | Heart |
| D  | Diamond  |

Poker terminology
- SB = Small Blind
- BB = Big Blind

### Example Keys (Address, Public Key (Not compressed), WIF Private Key)
*Alice* 
- msPJhg9GPzMN6twknwmSQvrUKZbZnk51Tv 
- 041FA97EFD760F26E93E91E29FDDF3DDDDD3F543841CF9435BDC156FB73854F4BF22557798BA535A3EE89A62238C5AFC7F8BF1FA0985DC4E1A06C25209BAB78BD1 
- 93Loqe8T3Qn3fCc87AiJHYHJfFFMLy6YuMpXzffyFsiodmAMCZS

*Bob* 
- mhSW3EUNoVkD1ZQV1ZpnxdRMBjo648enyo 
- 04F48396AC675B97EEB54E57554827CC2B937C2DAE285A9198F9582B15C920D91309BC567858DC63357BCD5D24FD8C041CA55DE8BAE62C7315B0BA66FE5F96C20D 
- 91yMBYURGqd38spSA1ydY6UjqWiyD1SBGJDuqPPfRWcpG53T672

*Witness* 
- mq1Ctw6xTcomjGgQz5pi8oXdR1tjjZQHYs
- 04C82B8E2D6EA7F17665C4A1070F340E84D4C02DA72AE5018574001841C10E8009A04E2C333D3EB90102E71B324BFE595430D4C654BBFF0F66EDBFE63798C7A271
- 93C4fbYtv8VXWDnbJLzQiVfBGuQgfz1hBF1QwQeJxQepe9oE876

*2 of 3 address
2NCSTuV27SC1BF122Xe1wmkNkjo4MJw4W85
https://testnet.blockexplorer.com/address/2NCSTuV27SC1BF122Xe1wmkNkjo4MJw4W85

*Redeem Script* 524104c82b8e2d6ea7f17665c4a1070f340e84d4c02da72ae5018574001841c10e8009a04e2c333d3eb90102e71b324bfe595430d4c654bbff0f66edbfe63798c7a2714104f48396ac675b97eeb54e57554827cc2b937c2dae285a9198f9582b15c920d91309bc567858dc63357bcd5d24fd8c041ca55de8bae62c7315b0ba66fe5f96c20d4104f48396ac675b97eeb54e57554827cc2b937c2dae285a9198f9582b15c920d91309bc567858dc63357bcd5d24fd8c041ca55de8bae62c7315b0ba66fe5f96c20d53ae

References:
http://ms-brainwallet.org

https://coinb.in/?verify=524104c82b8e2d6ea7f17665c4a1070f340e84d4c02da72ae5018574001841c10e8009a04e2c333d3eb90102e71b324bfe595430d4c654bbff0f66edbfe63798c7a2714104f48396ac675b97eeb54e57554827cc2b937c2dae285a9198f9582b15c920d91309bc567858dc63357bcd5d24fd8c041ca55de8bae62c7315b0ba66fe5f96c20d4104f48396ac675b97eeb54e57554827cc2b937c2dae285a9198f9582b15c920d91309bc567858dc63357bcd5d24fd8c041ca55de8bae62c7315b0ba66fe5f96c20d53ae#verify

### Test PGP Private and Public Keys

*Alice*
-----BEGIN PGP PRIVATE KEY BLOCK-----
Version: OpenPGP.js v.1.20130420
Comment: http://openpgpjs.org

xcA4BFb6E1MBAf9pyMRXuXc9A7DR8dDe7zkVEksMfOIDuYAE/Kd4cfbpRLRJ
5Ph0iVi69XU3GV1KS+1ThkqrlU94p8/WKAQRjdt7ABEBAAEAAf4gqwavjLAd
IJmnjEUTw87eCgMxPRPTUKMPZzMUyCUXTmFs3q+DGVnIDs928fgNS0RIovSB
GXZnx6uH74qKqg8BAQCxcsy4qvapXHAHmHVgxvgkQFa7xec/nXNKcCJ8xZiq
gQEAmJyuUqmFxaa9FtOOz+9lHqVG5L6E/1V0jupaWHsRL/sA/RDQgcmIZlo3
jGDX1zK6kt5H65pUKjZqFSFdS5vwT1HXUInNJFRlc3QgTWNUZXN0aW5ndG9u
IDx0ZXN0QGV4YW1wbGUuY29tPsJcBBABCAAQBQJW+hNTCRBx4oH3PIZldwAA
DO8B/0Lf1eqIfbBCIhqq4n7ge/qy5ITQKtMT1+P2pSqGj2+6/hUQhmHcvqBq
Sp07i29QBZiup2mExktQMaMvCLD40Vo=
=tIvp
-----END PGP PRIVATE KEY BLOCK-----

-----BEGIN PGP PUBLIC KEY BLOCK-----
Version: OpenPGP.js v.1.20130420
Comment: http://openpgpjs.org

xk0EVvoTUwEB/2nIxFe5dz0DsNHx0N7vORUSSwx84gO5gAT8p3hx9ulEtEnk
+HSJWLr1dTcZXUpL7VOGSquVT3inz9YoBBGN23sAEQEAAc0kVGVzdCBNY1Rl
c3Rpbmd0b24gPHRlc3RAZXhhbXBsZS5jb20+wlwEEAEIABAFAlb6E1MJEHHi
gfc8hmV3AAAM7wH/Qt/V6oh9sEIiGqrifuB7+rLkhNAq0xPX4/alKoaPb7r+
FRCGYdy+oGpKnTuLb1AFmK6naYTGS1Axoy8IsPjRWg==
=cWad
-----END PGP PUBLIC KEY BLOCK-----

*Bob*
-----BEGIN PGP PRIVATE KEY BLOCK-----
Version: OpenPGP.js v.1.20130420
Comment: http://openpgpjs.org

xcA4BFb6FKoBAgC5MgyxxJSELbTHZpN6T8H5ncblOmZkXrFlXtxC9acdReg/
15PWiB0omxzDRI0PvUsRHIcgJvd9h97Nq2F6eUITABEBAAEAAf9nk9SBwD6I
Rr/rHjWxnNYSc+n/3s/Rpxx0Y7+xO49B0RmLVBEt8QljZIkc/tXC4HqwzpwW
FmLQFrPqUWoKtkWhAQDmINi1D92m3B4zjgqQ94ZPgiWrGsN+hoPJlWj0JyPc
eQEAzgQGc5iRhOSQJ+35Rw0ma0h/kAOHB6nUYWywE7P3F+sBAIOkByxHtuQi
z2PmIxN9pRa6VQrm84HBpOWfzXEqS2J0UULNJFRlc3QgTWNUZXN0aW5ndG9u
IDx0ZXN0QGV4YW1wbGUuY29tPsJcBBABCAAQBQJW+hSrCRAT+yaNasjJggAA
1W0CAJRnrk8vd6PJhoBrH22U8ninyQahVmdmQ31jwdvVuENUNNPmxVD2UPQJ
nuiaFDXyQsyWs/nnbliJdS4F1HtGOCA=
=B2vt
-----END PGP PRIVATE KEY BLOCK-----

-----BEGIN PGP PUBLIC KEY BLOCK-----
Version: OpenPGP.js v.1.20130420
Comment: http://openpgpjs.org

xk0EVvoUqgECALkyDLHElIQttMdmk3pPwfmdxuU6ZmResWVe3EL1px1F6D/X
k9aIHSibHMNEjQ+9SxEchyAm932H3s2rYXp5QhMAEQEAAc0kVGVzdCBNY1Rl
c3Rpbmd0b24gPHRlc3RAZXhhbXBsZS5jb20+wlwEEAEIABAFAlb6FKsJEBP7
Jo1qyMmCAADVbQIAlGeuTy93o8mGgGsfbZTyeKfJBqFWZ2ZDfWPB29W4Q1Q0
0+bFUPZQ9Ame6JoUNfJCzJaz+eduWIl1LgXUe0Y4IA==
=Amq+
-----END PGP PUBLIC KEY BLOCK-----


## The protocol
Each client connects to one another in the "lobby".  They can then look for players who are looking to start a game, or request to join a running game.  Messages are sent to all players, signed, and referencing the existing message.  Thus like a block chain of messages.

- Table reaches consensus on whos turn to act
- Table reaches conesnsus on the legal moves / actions a player can make
- Table waits for a signed message from that player
- All other players validate that message
- Repeat

### Sample Message types
- Join
- Quit
- Action
- Shuffle Request

### Overview
If the game is to be developed using Etherum contracts:

1.  The game is defined an an Etherum contract
2.  Players agree to the table contract
3.  Each players actions are defined as inputs for the hand contract
4.  After the hand has ended, each player verifies the integrety of the hand contract.  Its in everyones best intrest to verify correctly [Game Theory Citation]
5.  The hand inputs are then excuted on the Etherum network for the pot to be awarded

Less use of Etherum

1.  Players connect to each other via P2P
2.  A player either looks to join a table and reviews the contract
3.  A palyer can choose to start a table be defining a table contract
4.  Tables should also broad cast their game, status and number of current players to other tables
5.  Leaving the table (closing the channel)
5.  Lightning network will facilitate micro payments "off chain".  The table can agree to bring them "on chain" after n hands are dealt.

### Aside:  Lightning Network

*How it Works.* 

Funds are placed into a two-party, multisignature "channel" bitcoin address. This channel is represented as an entry on the bitcoin public ledger. In order to spend funds from the channel, both parties must agree on the new balance. The current balance is stored as the most recent transaction signed by both parties, spending from the channel address. To make a payment, both parties sign a new exit transaction spending from the channel address. All old exit transactions are invalidated by doing so.

The Lightning Network does not require cooperation from the counterparty to exit the channel. Both parties have the option to unilaterally close the channel, ending their relationship. Since all parties have multiple multisignature channels with many di erent users on this network, one can send a payment to any other party across this network.

By embedding the payment conditional upon knowledge of a secure cryptographic hash, payments can be made across a network of channels without the need for any party to have unilateral custodial ownership of funds. The Lightning Network enables what was previously not possible with trusted financial systems vulnerable to monopolies—without the need for custodial trust and ownership, participation on the network can be dynamic and open for all.

[https://lightning.network/lightning-network-summary.pdf]

## Game as a contract
In the below *table contract* the below game Texas Holdem is defined as an Enum.  The whole rules of the game could be defined as a contract, thus allowing anyone to develop variations of the game, such as the "Seven Duce" rule, other variations of poker such as Ohmaha or even other games.  

These are out side the scope of this paper.

## Table Contract
The paramaters for a table are defined in the following schema.  Developers are encouraged to create their own algorithms, such as voting or anti-collusion.

1.  Encryption Algorithm (Enum AES-256)
2.  Hash Algorithm (Enum SHA-256)
3.  Table ID (GUID)
3.  Currency (Enum)
3.  Blinds
4.  Rake*
5.  Min players
6.  Max players
7.  Game type (Enum, No Limit Texas Holdem) *
8.  Other (straddles, "run it twice") *
9.  Channel Address / multisig
10.  Consensus Algorithm
11.  Anti Collusion Algorithm / Contract
12.  Version
13.  Voting Algorithm / Contract
14.  Channel Address

* Perhaps an entire contract

*Example xml serialziation*
```
<Table Id="bf368921-346a-42d8-9cb8-621f9cad5e16" Address="3P1c61hiSBuZstuVkECYo8ntDPVsnG2EQh" AddressType"2-3">
  <Encryption>AES-265</Encryption>
  <Hash>SHA-256</Hash>
  <Currency>BTC</Currency>
  <Blinds>
    <SmallBlind>0.001</SmallBlind>
    <BigBlind>0.002</BigBlind>
  </Blinds>
  <BuyIn>
    <Min>0.1</Min>
    <Max<0.2</Max>
  </BuyIn>
  <Game>
    <Type>Texas Holdem</Type>
    <Limit>No Limit</Limit>
  </Game>
  <Clock>30</Clock>
  <TimeOuts>120</TimeOut>
  <Version>0.0.1</Version>
</Table>
```

## Witness nodes
Game witness can also be allowed or chosen to arbitrate a game.  The witness could also help network propigation.  A witness would be choose by the table starter and a small rake paid to the witness.

There will become a market for reputable witnesses based off a https dns endpoint and earn small revenues for witnessing hands.

## Buying in
A player buying in opens a lightning payment channel with all players.

"Through this network of interconnected payment channels, Lightning provides a scalable, decentralized micropayments solution on top of the Bitcoin blockchain." [https://lightning.network/lightning-network-technical-summary.pdf]

1.  Alice creates a deposit transaction
2.  Bob creates a deposit transaction

Alice tx  f5c5e008f0cb9fc52487deb7531a8019e2d78c51c3c40e53a45248e0712102a3
Bob tx c60193a33174a1252df9deb522bac3e5532e0c756d053e4ac9999ca17a79c74e

*Sample opening lightning channel in c# / NBitcoin*
```
```

## Game play
The dealer's client is responsible for the orchastration of the game.  As the dealer position rotates, this isn't a centralisation risk.  The intnet is to limit network traffic.
1.  Define the hand contract
2.  Shuffle the deck
3.  Post blinds
4.  Pre flop round
5.  Deal the flop
6.  Post flop round
7.  Deal the turn
8.  Post turn round
9.  Deal the river
10.  Post river round
11.  Award the pot

### Hand Contract
At the start of each hand, the dealer defines the hand contract which references the table contract.  

1.  The players and seat postions
2.  The stack of each player
3.  A new "Private" Key to add entropy so hands can not be pre computed.  (IV or Salt instead?)

*Example hand contract seralized in XML
```
<Hand Key="HBFwc/qnlFqkxwiXTmNkXw==" TableContract="5ed4565da9b0cf46f8e3b6a5e6353d0c41b7d1b88234de5310315be670c2cf13">
  <Seat Number="1" Position="SB" Stack="1.01">mhSW3EUNoVkD1ZQV1ZpnxdRMBjo648enyo</Seat>
  <Seat Number="2" Position="BB,Dealer" Stack="0.9">msPJhg9GPzMN6twknwmSQvrUKZbZnk51Tv</Seat>
  <Witness>mq1Ctw6xTcomjGgQz5pi8oXdR1tjjZQHYs</Witness>
<Hand>
```

### The Shuffle
In this example, we will use a "Heads up" game of No Limit Texas Holdem.  In this case the hand contract defines Alice is the dealer, Bob the small blind, and Alice the big blind.

- Alice = msPJhg9GPzMN6twknwmSQvrUKZbZnk51Tv
- Bob = mhSW3EUNoVkD1ZQV1ZpnxdRMBjo648enyo

The deck is represented by an array[52].  

- Card[0] = AH
- Card[1] = KH
- Card[2] = QH
- Card[3] = JH
...
- Card[51] = 2C

### Alice shuffles the deck and does not disclose the un-encrypted result.
- Card[0] = AC
- Card[1] = 3S
- Card[2] = AH
- Card[3] = 2S

Create an array of 52 private keys, 16 bytes represented as base64.  These do not leave Alices computer.  *See test data for full set.
- Key[0]=ro4So+aeT6VJt9/OKTa/Ag==
- Key[1]=GcL2OvzsDg54RIZZ5ruMFA==
- Key[2]=HEKFpbtQnjl715X5P+8Y8g==
- Key[3]=2cXOWr/IQcJ/AyqhF/W/jg==

Each card is double encrypted.  First round of encryption with the hand key.  In the example key = HBFwc/qnlFqkxwiXTmNkXw== (1c 11 70 73 fa a7 94 5a a4 c7 08 97 4e 63 64 5f) in hex.

- Card[0]=
- Card[1]=
- Card[2]=
- Card[3]=

Then each card is encrypted again with the matching key and represented as base64.  Eg, card[0] is encrypted with key[0]
- Card[0]=

#### Alice sends the deck to Bob
As the deck is encrypted, and assumed shuffled, Bob has no way to known the contents of the deck.  Bob the encrypts the deck again and shuffles, and sends the result back to Alice.

*Example message in xml*
```
<Deck>
  <Card Index="0"></Card>
  <Card Index="1"></Card>
  ...
  <Card Index="51"></Card>
  <Signature>
  <![CDATA[
  -----BEGIN PGP SIGNATURE-----
  Version: OpenPGP.js v1.0.1
  Comment: http://openpgpjs.org
  
  wlwEAQEIABAFAlb6E4IJEHHigfc8hmV3AABO5QH/YrvNcYsG+F6J8QJ99Mq2
  gtbA1oWxHJo9j9NXpfvxVQbjv4ZQtvGbQ9qQJY5eKBDMlcgW8Dz6Tl7E1DXq
  SGSzdg==
  =M2wV
  -----END PGP SIGNATURE-----
  ]]>
  </Signature>
<Deck>
```

*Note:  The deck could also be shuffled by a witness.

### Post blinds

### Pre flop
We know how the distribution of cards that will be dealt.  In Holdem, each card is dealt one at a time, starting left of the dealer (small blind) [Citation 1]

- Card[0] => Bob
- Card[1] => Alice
- Card[2] => Bob
- Card[3] => Alice

- Alice -> Action request message to Bob.
- Bob -> Returns signed action message to Alice
- Alice -> Checks signature, and adds action response to the block
- Alice -> Broadcasts the concatinated block to all players
- All players -> Verifiy the block and signature
- All players -> Return verification message

*TODO: CREATE SEQUENCE DIAGRAM*

### Flop, Turn and River
The client software co-ordinates the game, based off agreed game rules. 

1.  Enforces action rules of its own player, such as check, bet or fold
2.  If the action involves money, creates the tx
3.  Creates a signed message and broad casts to each player
4.  Waits for next action message
5.  Validates the message

*Example action message from Bob serialzed in XML.  A call from the small blind.*
```
<Action Position="1" Address="mhSW3EUNoVkD1ZQV1ZpnxdRMBjo648enyo">
  <PreviousHash>d4f235a5f120224ca290c8bd76ba182db67873c04bfddffe13355a0f752f7b37</PreviousHash>
  <Call>
    <Amount>0.001</Amount>
    <Tx></Tx>
  </Call>
  <MessageSignature>
  </MessageSignature>
<Action>
<Hash Algorithm="SHA256">8df28bd9b4617cb0c425ff838926533252a3840b4e602fdb7e181f3968165929</Hash>
```

### Award the post. (Post hand consensus)
Once the hand has been played, the table then reaches consensus.  The signed game history could then be persistend into an Ethereum block chain referencing previous hands.  

Fee vs Payouts.  The table would also include a paramater when to commite the hand, or hand history, to a chain.  The more frequently it is done, the more fees it will incure. 

## Cashing out
Closing the channel

## Network Topology

### Dealing with disconnects

## Betting via lightning channels
Each bet is a signature from the punter that is not broad cast to the network.   For example, in the heads up game, if both Alice and Bob post blinds, the net transfer result = 0.

## Settlement


## Test Data
- Alice keys
- Bob keys
For full key set, see the test data folder

### Mock API
An REST API is located at 
https://bitpoker.azurewebsites.net/api

GET /Players
GET /Players/<bitcoinaddress>


## References
1. https://lightning.network/lightning-network-paper.pdf
2. http://www.pokerlistings.com/poker-rules-texas-holdem
3. http://ianpurton.com/online-pgp/
4. http://www.codeproject.com/Articles/835098/NBitcoin-Build-Them-All
