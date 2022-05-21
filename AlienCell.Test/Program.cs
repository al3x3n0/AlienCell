using System;
using Grpc.Net.Client;
using MagicOnion.Client;
using MessagePack;
using Nethereum.Signer;

using AlienCell.Shared.Services;

var channel = GrpcChannel.ForAddress("http://localhost:5162");

// NOTE: If your project targets non-.NET Standard 2.1, use `Grpc.Core.Channel` class instead.
// var channel = new Channel("localhost", 5001, new SslCredentials());

var address = "0x6530675f096Cf36046d6839750c5C6Ee6C2354E2";
var privKey = "0x5182c0c53f67a3b1db51f712c0c2e007bc8f138b55f8c76a4540fb61aa253ce6";

/*
Console.WriteLine("Trying to login...");
var client = MagicOnionClient.Create<IAuthService>(channel);
var challengeResp = await client.ChallengeAsync(address);
Console.WriteLine($"Got challenge: {challengeResp.Challenge}");
//
var signer = new EthereumMessageSigner();
var signature = signer.HashAndSign(challengeResp.Challenge, privKey);
var validateResp = await client.ValidateAsync(address, signature);
Console.WriteLine($"Success: {validateResp.Success}");
if (validateResp.Success)
{
    Console.WriteLine($"Got token: {validateResp.Token}\nExpires: {validateResp.Expiration}");
}
*/

var msgPackResolver = MessagePack.Resolvers.CompositeResolver.Create(
    Cysharp.Serialization.MessagePack.UlidMessagePackResolver.Instance,
    MessagePack.Resolvers.StandardResolver.Instance);

var msgPackoptions = MessagePackSerializerOptions.Standard.WithResolver(msgPackResolver);
MessagePackSerializer.DefaultOptions = msgPackoptions;

var cheatsClient = MagicOnionClient.Create<ICheatService>(channel);
var gsClient = MagicOnionClient.Create<IGameService>(channel);
//var userId = await cheatsClient.CreateNewUser();
//Console.WriteLine($"New user ID: {userId.ToString()}");

var userId = Ulid.Parse("01G3F0WVN1HFE4FAXCSN554BWX");
var user = await gsClient.GetUserAsync(userId);
Console.WriteLine($"User id: {user.Exp}");


//var client = MagicOnionClient.Create<IGameService>(channel);
//Console.WriteLine($"Lolling!");
//var res = await client.GetUserAsync(1);
//Console.WriteLine($"Got result: {res}");
