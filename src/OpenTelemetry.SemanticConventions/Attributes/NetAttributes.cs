// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

// <auto-generated>This file has been auto generated from 'src\OpenTelemetry.SemanticConventions\scripts\templates\registry\SemanticConventionsAttributes.cs.j2' </auto-generated>

#nullable enable

#pragma warning disable CS1570 // XML comment has badly formed XML

namespace OpenTelemetry.SemanticConventions;

/// <summary>
/// Constants for semantic attribute names outlined by the OpenTelemetry specifications.
/// </summary>
public static class NetAttributes
{
    /// <summary>
    /// Deprecated, use <c>network.local.address</c>
    /// </summary>
    [Obsolete("Replaced by <c>network.local.address</c>")]
    public const string AttributeNetHostIp = "net.host.ip";

    /// <summary>
    /// Deprecated, use <c>server.address</c>
    /// </summary>
    [Obsolete("Replaced by <c>server.address</c>")]
    public const string AttributeNetHostName = "net.host.name";

    /// <summary>
    /// Deprecated, use <c>server.port</c>
    /// </summary>
    [Obsolete("Replaced by <c>server.port</c>")]
    public const string AttributeNetHostPort = "net.host.port";

    /// <summary>
    /// Deprecated, use <c>network.peer.address</c>
    /// </summary>
    [Obsolete("Replaced by <c>network.peer.address</c>")]
    public const string AttributeNetPeerIp = "net.peer.ip";

    /// <summary>
    /// Deprecated, use <c>server.address</c> on client spans and <c>client.address</c> on server spans
    /// </summary>
    [Obsolete("Replaced by <c>server.address</c> on client spans and <c>client.address</c> on server spans")]
    public const string AttributeNetPeerName = "net.peer.name";

    /// <summary>
    /// Deprecated, use <c>server.port</c> on client spans and <c>client.port</c> on server spans
    /// </summary>
    [Obsolete("Replaced by <c>server.port</c> on client spans and <c>client.port</c> on server spans")]
    public const string AttributeNetPeerPort = "net.peer.port";

    /// <summary>
    /// Deprecated, use <c>network.protocol.name</c>
    /// </summary>
    [Obsolete("Replaced by <c>network.protocol.name</c>")]
    public const string AttributeNetProtocolName = "net.protocol.name";

    /// <summary>
    /// Deprecated, use <c>network.protocol.version</c>
    /// </summary>
    [Obsolete("Replaced by <c>network.protocol.version</c>")]
    public const string AttributeNetProtocolVersion = "net.protocol.version";

    /// <summary>
    /// Deprecated, use <c>network.transport</c> and <c>network.type</c>
    /// </summary>
    [Obsolete("Split to <c>network.transport</c> and <c>network.type</c>")]
    public const string AttributeNetSockFamily = "net.sock.family";

    /// <summary>
    /// Deprecated, use <c>network.local.address</c>
    /// </summary>
    [Obsolete("Replaced by <c>network.local.address</c>")]
    public const string AttributeNetSockHostAddr = "net.sock.host.addr";

    /// <summary>
    /// Deprecated, use <c>network.local.port</c>
    /// </summary>
    [Obsolete("Replaced by <c>network.local.port</c>")]
    public const string AttributeNetSockHostPort = "net.sock.host.port";

    /// <summary>
    /// Deprecated, use <c>network.peer.address</c>
    /// </summary>
    [Obsolete("Replaced by <c>network.peer.address</c>")]
    public const string AttributeNetSockPeerAddr = "net.sock.peer.addr";

    /// <summary>
    /// Deprecated, no replacement at this time
    /// </summary>
    [Obsolete("Removed")]
    public const string AttributeNetSockPeerName = "net.sock.peer.name";

    /// <summary>
    /// Deprecated, use <c>network.peer.port</c>
    /// </summary>
    [Obsolete("Replaced by <c>network.peer.port</c>")]
    public const string AttributeNetSockPeerPort = "net.sock.peer.port";

    /// <summary>
    /// Deprecated, use <c>network.transport</c>
    /// </summary>
    [Obsolete("Replaced by <c>network.transport</c>")]
    public const string AttributeNetTransport = "net.transport";

    /// <summary>
    /// Deprecated, use <c>network.transport</c> and <c>network.type</c>
    /// </summary>
    public static class NetSockFamilyValues
    {
        /// <summary>
        /// IPv4 address
        /// </summary>
        [Obsolete("Split to <c>network.transport</c> and <c>network.type</c>")]
        public const string Inet = "inet";

        /// <summary>
        /// IPv6 address
        /// </summary>
        [Obsolete("Split to <c>network.transport</c> and <c>network.type</c>")]
        public const string Inet6 = "inet6";

        /// <summary>
        /// Unix domain socket path
        /// </summary>
        [Obsolete("Split to <c>network.transport</c> and <c>network.type</c>")]
        public const string Unix = "unix";
    }

    /// <summary>
    /// Deprecated, use <c>network.transport</c>
    /// </summary>
    public static class NetTransportValues
    {
        /// <summary>
        /// ip_tcp
        /// </summary>
        [Obsolete("Replaced by <c>network.transport</c>")]
        public const string IpTcp = "ip_tcp";

        /// <summary>
        /// ip_udp
        /// </summary>
        [Obsolete("Replaced by <c>network.transport</c>")]
        public const string IpUdp = "ip_udp";

        /// <summary>
        /// Named or anonymous pipe
        /// </summary>
        [Obsolete("Replaced by <c>network.transport</c>")]
        public const string Pipe = "pipe";

        /// <summary>
        /// In-process communication
        /// </summary>
        [Obsolete("Replaced by <c>network.transport</c>")]
        public const string Inproc = "inproc";

        /// <summary>
        /// Something else (non IP-based)
        /// </summary>
        [Obsolete("Replaced by <c>network.transport</c>")]
        public const string Other = "other";
    }
}
