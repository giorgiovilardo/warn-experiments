# Warn experiments

Mystical stuff happens with protobuf

## Usage

* Compile `person.proto`
  * use docker i cant be bothered to install `protoc` and it has 238493489 deps
  * `docker run -v $PWD:/defs --platform=linux/amd64 namely/protoc-all -f person.proto -l csharp -o .`
* Open the `sln`
* Take a look at Program.cs
