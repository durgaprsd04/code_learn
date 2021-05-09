# About JWT cookies
1. This code generates random JWT tokens based on config
2. Idea is some user can request a JWT token
3. User will get get JWT token and make the request again wth token.
4. After a while JWT token will expire and  requests will fail.
5. Features of JWT include

    1. No session maintenance.
    2. Low security as key can be compromised.
    3. has header signature and payload
    4. payload and all can be decoded but signature can't be.
    5. JWT signatures are reproduced rather than decrypted
6. Storing JWT is a problem (XSS and CSRF attacks)
7. Public private auth mechanims are there to avoid this.
