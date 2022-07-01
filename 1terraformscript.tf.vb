provider "aws" {
  region = " ap-south-1"
  access_key = "AKIA3GKX7UKIVC32PQ4T"
  secret_key = "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"
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
