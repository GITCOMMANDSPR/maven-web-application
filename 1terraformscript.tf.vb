provider "aws" {
  region = " ap-south-1"
  access_key = "         "
  secret_key = "         "
}
resource "aws_instance" "AWSEC2Instance" {
  ami = "          "
  instance_type = "t2.micro"
  security_groups = ["         "]
  key_name = "         "
  tags = {
    Name = " RedHat server by terraform"
  }
}