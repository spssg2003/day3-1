# HTTP

Codified in [RFC 2616](https://www.rfc-editor.org/rfc/rfc2616.html)

Http is an _application layer_ protocol.

| Internet Protocol Layers | WWW                  |
| ------------------------ | -------------------- |
| Application Layer        | HTTP                 |
| Transport Layer          | TCP\*                |
| Internet Layer           | IP                   |
| Network Access Layer     | Ethernet, Wifi, etc. |

Note: In HTTP3, sometimes UDP is used at the transport layer.

## Resource Oriented Architecture

### Key Terms

#### Resources

A _meaningful thingy_ you want to expose from your API. Is named with a "Uniform Resource Identitifier", in the form of:

`https://api.domain.com/path-to-resource`

- https is the _scheme_
- api.domain.com is the _authority_ or _server_, or _origin_
- path-to-resource is the name of the resource on that authority.

#### Scheme

Either `HTTP` or `HTTPS`. If HTTPS, it is using TLS (Transport Layer Security), using a combination of symmetric and asymmetric encryption.

#### Origin

The server software that implements the HTTP Protocol. Often called "Server", or "Authority" in HTTP parlance.

The software is a "web server" and run on a TCP Port. Port 80 is the default for the WWW, and need not be specified if that is what is being used.

#### Resource (Path)

A unique name for a resource on that authority.

Multiple names can be given for the same logical resource, e.g.

`/employees/13` could be employee Denis and so could

`/employee-of-the-month`

#### Consistent Interface Constraint of HTTP

HTTP Resources are accessed using a standard set of _verbs_ or _methods_ by directing Request messages to them.

Request Messages have:

- A request line
- A set of headers
- (optional) a blank line
- (optional) a body (or entity)

```http
GET /tacos HTTP/1.1
Server: tacobell.com
Accept: application/json
```

```http
POST /tacos HTTP/1.1
Server: tacobell.com
Accept: application/json
Content-Type: applicaton/json

{
    "type": "Gordita Supreme"
}
```

Servers create HTTP Response Messages.

Response messages have:

- A Response Line
- A set of headers
- (optional) a blank line
- (optional) a body (or entity)

```http
201 Created HTTP/1.1
Server: tacobell.com
Date: Monday, November 11 2022 1:18 GMT
Location: http://tacobell.com/tacos/19
Content-Type: application/json

{
    "id": "19",
    "type": "Gordita Supreme"
}
```
