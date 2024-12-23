
# TODO
- Add database
  - Connect database to main project
  - Add DB migrations
- Swap slots
  - https://www.reddit.com/r/AZURE/comments/ih5o9r/github_action_for_swapping_deployment_slots/?rdt=63156
  - https://github.com/Azure/login?tab=readme-ov-file#login-with-user-assigned-managed-identity
- Pre-Deployment Checks and scripts
  - Startup tests
    - Add applicationInitialization
    - WEBSITE_WARMUP_PATH, WEBSITE_SWAP_WARMUP_PING_PATH, WEBSITE_SWAP_WARMUP_PING_STATUSES
      - https://learn.microsoft.com/en-us/azure/app-service/deploy-staging-slots
      - https://haacked.com/archive/2020/09/28/azure-swap-with-warmup-aspnetcore/
  - Startup scripts?
    - .deployment file
    - run.cmd in /run folder
- Inputs?
  - https://github.blog/changelog/2021-11-10-github-actions-input-types-for-manual-workflows/

# TESTING
- https://github.com/dorny/test-reporter
- https://cicube.io/workflow-hub/dorny-test-reporter/
- https://github.com/marketplace/actions/test-reporter

# ChatGPT
- https://chatgpt.com/c/67499d61-bcb8-8001-9543-7b74a37fcd1d

# DEPLOYMENT REFERENCES

- https://learn.microsoft.com/en-us/azure/app-service/deploy-github-actions?tabs=openid%2Caspnetcore

- https://docs.github.com/en/actions/use-cases-and-examples/deploying/deploying-net-to-azure-app-service

- https://docs.github.com/en/actions/use-cases-and-examples/building-and-testing/building-and-testing-net

- https://github.com/Azure/webapps-deploy

## Dorny Test Reporter
- https://bitwarden.com/blog/how-to-set-up-a-testing-workflow-for-a-net-library/

## Test Extensions

- https://docs.fluentvalidation.net/en/latest/


[deploy_to_staging.yml](.github%2Fworkflows%2Fdeploy_to_staging.yml)