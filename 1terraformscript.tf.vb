provider "aws" {
  region = "ap-south-1"
  access_key = "AKIA3GKX7UKIVC32PQ4T"
  secret_key = "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"
}
resource "aws_instance" "AWSEC2Instance" {
  ami = "ami-05c8ca4485f8b138a"
  instance_type = "t2.micro"
  security_groups = ["launch-wizard-1"]
  key_name = "demokey"
  tags = {
    Name = " RedHat server by terraform"
  }
}
